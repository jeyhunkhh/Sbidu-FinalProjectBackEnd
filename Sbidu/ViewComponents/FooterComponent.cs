using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sbidu.Data;
using Sbidu.Models;
using System.Linq;

namespace Sbidu.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public FooterComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public ViewViewComponentResult Invoke()
        {
            var footer = _context.Settings.FirstOrDefault();
            return View(footer);
        }
    }
}
