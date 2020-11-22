using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sbidu;
using Sbidu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AuctionWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public Worker(ILogger<Worker> logger,
                      IServiceScopeFactory serviceScopeFactory)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentNullException(nameof(serviceScopeFactory));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _serviceScopeFactory.CreateScope();
                var _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var auction = _context.AuctionProducts.Where(x => x.EndDate < DateTime.Now && x.Sold == false && x.NoBuyer == false)
                                                      .Include(x => x.UserAuctionProducts)
                                                      .ToList();
                

                if (auction.Count > 0) 
                {
                    
                    var winner = auction.FirstOrDefault().UserAuctionProducts
                                                            .OrderByDescending(x => x.Bid)
                                                            .FirstOrDefault();
                    if(winner != null)
                    {
                        auction.FirstOrDefault().Sold = true;
                        winner.IsWinner = true;
                        winner.SoldPrice = winner.Bid;
                    }
                    else
                    {
                        auction.FirstOrDefault().NoBuyer = true;
                    }
                    
                    _context.SaveChanges();
                }

                _logger.LogInformation(_context.AuctionProducts.FirstOrDefault().Id.ToString());
                //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}


