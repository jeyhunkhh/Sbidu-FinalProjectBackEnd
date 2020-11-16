using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    public class AuctionDetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuctionDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("auction-detail")]
        public IActionResult Index(int Id)
        {

            AuctionDetailViewModel model = new AuctionDetailViewModel
            {
                AuctionProduct = _context.AuctionProducts.Where(x => x.EndDate > DateTime.Now)
                                         .Include(x => x.AuctionProductGalleries)
                                         .Include(x => x.UserAuctionProducts)
                                         .ThenInclude(x => x.AppUser)
                                         .FirstOrDefault(x=>x.Id == Id),
                Faq = _context.Faqs.ToList()
            };

            return View(model);
        }
    }
}
