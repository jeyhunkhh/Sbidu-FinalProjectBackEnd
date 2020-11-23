using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Sbidu.Data;
using Sbidu.Models;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    
    public class AuctionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AuctionController(ApplicationDbContext context,
                              UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("auction/{Id?}")]
        public async Task<IActionResult> Index(int? Id, int page = 1, int pageSize = 4)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                ViewBag.User = user;
            }

            if (Id == null)
            {
                Id = _context.Categories.FirstOrDefault().Id;
            }
            
            var items = _context.AuctionProducts
                    .Include(x => x.AuctionProductGalleries)
                    .Where(x => x.CategoryId == Id)
                    .Include(x => x.UserAuctionProducts)
                    .Where(x => x.Sold == false && x.EndDate > DateTime.Now)
                    .AsNoTracking().OrderBy(x => x.EndDate);

            var pagingData = await PagingList.CreateAsync(items, pageSize, page);

            AuctionViewModel auction = new AuctionViewModel
            {
                PagingList = pagingData,

                AuctionProductsPopular = _context.AuctionProducts
                    .Include(x => x.AuctionProductGalleries)
                    .Include(x => x.UserAuctionProducts)
                    .ThenInclude(x=>x.AppUser)
                    .Where(x => x.Sold == false && x.EndDate > DateTime.Now)
                    .Where(x=>x.Popular == true).ToList(),

                Categories = _context.Categories.ToList()
            };

            return View(auction);
        }
    }
}
