using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Helper;
using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public CategoryController(ApplicationDbContext context,
                                     IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Control/HomeHeaders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Control/HomeHeaders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Control/HomeHeaders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeHeaders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Upload,Id,Type,Icon")] Category categories)
        {
            if (categories.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(categories.Upload);
                categories.Photo = fileName;
                _context.Add(categories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categories);
        }

        // GET: Control/HomeHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Control/HomeHeaders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Photo,Upload,Id,Type,Icon")] Category categories)
        {
            if (id != categories.Id)
            {
                return NotFound();
            }
                if (ModelState.IsValid)
                {
                    try
                    {
                    if (categories.Upload != null)
                    {
                        var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", categories.Photo);
                        _fileManager.Delete(oldFile);
                        var fileName = _fileManager.Upload(categories.Upload);
                        categories.Photo = fileName;
                    }
                        _context.Update(categories);
                        await _context.SaveChangesAsync();  
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CategoriesExists(categories.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
            
            return View(categories);
        }

        // GET: Control/HomeHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeHeader = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeHeader == null)
            {
                return NotFound();
            }

            return View(homeHeader);
        }

        // POST: Control/HomeHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            try
            {
                _fileManager.Delete(category.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriesExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
