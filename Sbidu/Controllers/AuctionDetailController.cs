using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Models;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    public class AuctionDetailController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AuctionDetailController(ApplicationDbContext context,
                                       UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize()]
        [Route("auction-detail/{Id}")]
        public IActionResult Index(int Id, AuctionDetailViewModel viewModel)
        {
             
            AuctionDetailViewModel model = new AuctionDetailViewModel
            {
                AuctionProduct = _context.AuctionProducts.Where(x => x.EndDate > DateTime.Now)
                                         .Include(x => x.AuctionProductGalleries)
                                         .Include(x => x.UserAuctionProducts)
                                         .ThenInclude(x => x.AppUser)
                                         .FirstOrDefault(x => x.Id == Id),
                Faq = _context.Faqs.ToList()
            };

            if (viewModel.Bid != 0)
            {
                var auction = _context.AuctionProducts.Include(x => x.UserAuctionProducts)
                                                      .FirstOrDefault(x => x.Id == Id);

                if (viewModel.Bid < auction.StartPrice && viewModel.Bid >= 0)
                {
                    ModelState.AddModelError("", "Header than start price" + " - $" + auction.StartPrice);
                    return View(model);
                }

                var maxBid = auction.UserAuctionProducts.OrderByDescending(x => x.Bid).FirstOrDefault();

                if (maxBid != null)
                {
                    if (viewModel.Bid <= maxBid.Bid)
                    {
                        ModelState.AddModelError("", "Header than current price" + " - $" + maxBid.Bid);
                        return View(model);
                    }
                }

                var user = _userManager.FindByNameAsync(User.Identity.Name);

                UserAuctionProduct userAuction = new UserAuctionProduct
                {
                    AppUserId = user.Id,
                    AuctionProductId = Id,
                    Bid = viewModel.Bid,
                    AddDate = DateTime.Now
                };

                _context.UserAuctionProducts.Add(userAuction);
                _context.SaveChanges();
            }

            return View(model);

        }
    }
}
