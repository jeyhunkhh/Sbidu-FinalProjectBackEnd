using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Sbidu.Data;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    
    public class AuctionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuctionController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("auction/{Id?}")]
        public async Task<IActionResult> IndexAsync(int? Id, int page = 1, int pageSize = 4)
        {
            if(Id == null)
            {
                Id = _context.Categories.FirstOrDefault().Id;
            }

            var items = _context.AuctionProducts
                    .Include(x => x.AuctionProductGalleries)
                    .Where(x => x.CategoryId == Id)
                    .AsNoTracking().OrderBy(x => x.Id);

            var pagingData = await PagingList.CreateAsync(items, pageSize, page);

            AuctionViewModel auction = new AuctionViewModel
            {
                PagingList = pagingData,

                AuctionProductsPopular = _context.AuctionProducts
                    .Include(x => x.AuctionProductGalleries)
                    .Where(x=>x.Popular == true).ToList(),

                Categories = _context.Categories.ToList()
            };

            return View(auction);
        }
    }
}
