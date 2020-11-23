using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sbidu.ViewComponents
{
    public class AuctionPosterComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public AuctionPosterComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int Id)
        {
            List<AuctionProduct> products = _context.AuctionProducts
                .Where(x=>x.Sold == false)
                .Include(x=>x.AuctionProductGalleries)
                .Include(x => x.Category)
                .Include(x=> x.UserAuctionProducts)
                .Where(x=>x.EndDate > DateTime.Now)
                .Where(x => x.CategoryId == Id)
                .OrderBy(x=>x.EndDate).ToList();
            return View(products);
        }
    }
}
