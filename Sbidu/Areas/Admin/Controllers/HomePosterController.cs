using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sbidu.Data;
using Sbidu.Helper;
using Sbidu.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomePosterController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomePosterController(ApplicationDbContext context,
                                     IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Control/HomePoster
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePosters.ToListAsync());
        }

        // GET: Control/HomePoster/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePoster = await _context.HomePosters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePoster == null)
            {
                return NotFound();
            }

            return View(homePoster);
        }

        // GET: Control/HomePoster/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomePoster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Upload,Id,Subtitle,Text")] HomePoster homePoster)
        {
            if (homePoster.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(homePoster.Upload);
                homePoster.Photo = fileName;
                _context.Add(homePoster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePoster);
        }

        // GET: Control/HomePoster/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePoster = await _context.HomePosters.FindAsync(id);
            if (homePoster == null)
            {
                return NotFound();
            }
            return View(homePoster);
        }

        // POST: Control/HomePoster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Photo,Upload,Id,Subtitle,Text")] HomePoster homePoster)
        {
            if (id != homePoster.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (homePoster.Upload != null)
                    {
                        var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", homePoster.Photo);
                        _fileManager.Delete(oldFile);
                        var fileName = _fileManager.Upload(homePoster.Upload);
                        homePoster.Photo = fileName;
                    }
                    _context.Update(homePoster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePosterExists(homePoster.Id))
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

            return View(homePoster);
        }

        // GET: Control/HomePoster/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePoster = await _context.HomePosters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePoster == null)
            {
                return NotFound();
            }

            return View(homePoster);
        }

        // POST: Control/HomePoster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePoster = await _context.HomePosters.FindAsync(id);
            try
            {
                _fileManager.Delete(homePoster.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.HomePosters.Remove(homePoster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomePosters.Remove(homePoster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePosterExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
