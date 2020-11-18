﻿using System;
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
        public async Task<IActionResult> Index(int Id, AuctionDetailViewModel viewModel)
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
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = user;
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

                

                if (auction.UserAuctionProducts == null)
                {
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
                else
                {
                    auction.UserAuctionProducts.FirstOrDefault().Bid = viewModel.Bid;
                    auction.UserAuctionProducts.FirstOrDefault().AddDate = DateTime.Now;

                    _context.SaveChanges();
                }

            }

            return View(model);

        }

        public async Task<IActionResult> AddToWishlist(int Id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            await Helper.AddFavorites.AddFavorite(Id, _context, user);

            return NoContent();
        }

        //public async Task<IActionResult> AddFavorite(int Id)
        //{
        //    var auction = _context.AuctionProducts.Include(x => x.UserAuctionProducts).FirstOrDefault(x => x.Id == Id);
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    var isFavorite = auction.UserAuctionProducts.Where(x => x.IsFavorit == true).FirstOrDefault(x => x.AppUserId == user.Id);

        //    if(auction.UserAuctionProducts.Any(x => x.IsFavorit == false))
        //    {
        //        auction.UserAuctionProducts.Where(x => x.IsFavorit == false)
        //                                   .OrderBy(x => x.Bid)
        //                                   .FirstOrDefault().IsFavorit = true;

        //        _context.SaveChanges();
        //    }
        //    else if (isFavorite == null)
        //    {
        //        UserAuctionProduct userAuction = new UserAuctionProduct
        //        {
        //            AppUserId = user.Id,
        //            AuctionProductId = Id,
        //            IsFavorit = true,
        //            AddDate = DateTime.Now
        //        };

        //        _context.UserAuctionProducts.Add(userAuction);
        //        _context.SaveChanges();
        //    }
        //    else
        //    {
        //        isFavorite.IsFavorit = false;
        //        _context.SaveChanges();
        //    }

        //    return NoContent();
        //}

    }
}