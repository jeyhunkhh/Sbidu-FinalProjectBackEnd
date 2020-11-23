using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Models;
using Sbidu.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ApplicationDbContext context,
                              UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                ViewBag.User = user;
            }

            HomeViewModel homeViewModel = new HomeViewModel
            {
                HomePoster = _context.HomePosters.FirstOrDefault(),
                AuctionProducts = _context.AuctionProducts
                    .Where(x=>x.Sold == false && x.EndDate > DateTime.Now)
                    .Include(x=>x.AuctionProductGalleries)
                    .Include(x => x.UserAuctionProducts)
                    .Include(x=>x.Category).ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(homeViewModel);
        }

        public async Task<IActionResult> AddToWishlist(int Id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            await Helper.AddFavorites.AddFavorite(Id, _context, user);

            return NoContent();
        }
    }
}
