using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Helper;
using Sbidu.Models;
using Sbidu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AuctionProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;


        public AuctionProductController(ApplicationDbContext contex,
                                        IFileManager fileManager)
        {
            _fileManager = fileManager;
            _context = contex;
        }

        public IActionResult Index()
        {
            var auctionProduct = _context.AuctionProducts.Include(x => x.AuctionProductGalleries)
                                                         .Include(x => x.Category)
                                                         .Include(x => x.UserAuctionProducts)
                                                         .ThenInclude(x => x.AppUser).ToList();
            return View(auctionProduct);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuctionProductCreateViewModel model)
        {
            ViewBag.Categories = _context.Categories.ToList();

            if (model.Uploads == null)
            {
                ModelState.AddModelError("Uploads", "The Photo field is required.");
            }

            if(model.Uploads.Length < 4)
            {
                ModelState.AddModelError("Uploads", "The auction must have at least 4 photos.");
            }

            if (model.BuyNowPrice <= model.StartPrice)
            {
                ModelState.AddModelError("BuyNowPrice", "Buy now price must be bigger than start price.");
            }

            if(model.EndDate < DateTime.Now.AddDays(1))
            {
                ModelState.AddModelError("EndDate", "Auction must be at least 24 hours.");
            }

            if (ModelState.IsValid)
            {
                AuctionProduct product = new AuctionProduct()
                {
                    Name = model.Name,
                    About = model.About,
                    BuyNowPrice = model.BuyNowPrice,
                    StartPrice = model.StartPrice,
                    EndDate = model.EndDate,
                    CategoryId = model.CategoryId
                };

                _context.AuctionProducts.Add(product);
                _context.SaveChanges();

                
                foreach (var item in model.Uploads)
                {
                    AuctionProductGallery productGallery = new AuctionProductGallery();
                    var fileName = _fileManager.Upload(item);
                    productGallery.Photo = fileName;
                    productGallery.AuctionProductId = _context.AuctionProducts.OrderByDescending(x=>x.Id).FirstOrDefault().Id;
                    _context.AuctionProductGalleries.Add(productGallery);
                    _context.SaveChanges();
                }

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var auctionProduct = _context.AuctionProducts.Include(x => x.AuctionProductGalleries)
                                                         .Include(x => x.Category)
                                                         .Include(x => x.UserAuctionProducts)
                                                         .ThenInclude(x => x.AppUser).FirstOrDefault(x=>x.Id == Id);

            if (auctionProduct == null)
            {
                return NotFound();
            }

            return View(auctionProduct);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var auctionProduct = _context.AuctionProducts.Include(x => x.AuctionProductGalleries)
                                                         .Include(x => x.Category)
                                                         .Include(x => x.UserAuctionProducts)
                                                         .ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == Id);

            if (auctionProduct == null)
            {
                return NotFound();
            }

            return View(auctionProduct);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var auctionProduct = _context.AuctionProducts.Include(x => x.AuctionProductGalleries)
                                                         .Include(x => x.Category)
                                                         .Include(x => x.UserAuctionProducts)
                                                         .ThenInclude(x => x.AppUser).FirstOrDefault(x => x.Id == Id);

            foreach (var item in auctionProduct.AuctionProductGalleries)
            {
                _fileManager.Delete(item.Photo);
            }

            foreach (var item in auctionProduct.UserAuctionProducts)
            {
                _context.UserAuctionProducts.Remove(item);
            }

            _context.AuctionProducts.Remove(auctionProduct);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
