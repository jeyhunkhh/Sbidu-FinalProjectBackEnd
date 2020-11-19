using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Helper
{
    public static class AddFavorites
    {
        public async static Task<bool> AddFavorite(int Id, ApplicationDbContext _context, AppUser user)
        {
            var auction = _context.AuctionProducts.Include(x => x.UserAuctionProducts).FirstOrDefault(x => x.Id == Id);
            
            var isFavorite = auction.UserAuctionProducts.Where(x => x.IsFavorit == true).FirstOrDefault(x => x.AppUserId == user.Id);

            if (auction.UserAuctionProducts.Any(x => x.IsFavorit == false))
            {
                auction.UserAuctionProducts.Where(x => x.IsFavorit == false)
                                           .OrderBy(x => x.Bid)
                                           .FirstOrDefault().IsFavorit = true;

                _context.SaveChanges();
            }
            else if (isFavorite == null)
            {
                UserAuctionProduct userAuction = new UserAuctionProduct
                {
                    AppUserId = user.Id,
                    Bid = 0,
                    AuctionProductId = Id,
                    IsFavorit = true,
                    AddDate = DateTime.Now
                };

                _context.UserAuctionProducts.Add(userAuction);
                _context.SaveChanges();
            }
            else
            {
                isFavorite.IsFavorit = false;
                _context.SaveChanges();
            }

            return true;
        }
    }
}
