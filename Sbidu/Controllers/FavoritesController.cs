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
    public class FavoritesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public FavoritesController(ApplicationDbContext context,
                                UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize()]
        public async Task<IActionResult> Index()
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            MyProfileViewModel model = new MyProfileViewModel
            {
                AppUser = user,
                AuctionProduct = _context.AuctionProducts.ToList(),
                UserAuctionProducts = _context.UserAuctionProducts.Where(x => x.AppUserId == user.Id)
                                                                  .Include(x => x.AuctionProduct)
                                                                  .ThenInclude(x => x.AuctionProductGalleries).ToList()
            };

            return View(model);
        }

        public async Task<IActionResult> AddToWishlist(int Id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            await Helper.AddFavorites.AddFavorite(Id, _context, user);

            return RedirectToAction("Index");
        }
    }
}
