using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sbidu.Data;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AboutUsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("about-us")]
        public IActionResult Index()
        {
            AboutViewModel about = new AboutViewModel
            {
                Teams = _context.Teams.ToList()
            };

            return View(about);
        }
    }
}
