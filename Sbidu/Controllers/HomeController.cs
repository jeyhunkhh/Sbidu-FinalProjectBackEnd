using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.ViewModels;
using System.Linq;

namespace Sbidu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                HomePoster = _context.HomePosters.FirstOrDefault(),
                AuctionProducts = _context.AuctionProducts.Include(x=>x.AuctionProductGalleries).ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(homeViewModel);
        }
    }
}
