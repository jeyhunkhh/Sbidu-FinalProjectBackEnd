using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sbidu.Data;
using Sbidu.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HeaderComponent(ApplicationDbContext context,
                               UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            ViewBag.Fullname = "";
            ViewBag.Photo = null;
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.Fullname = user.FullName;
                ViewBag.Photo = user.Photo;
            }

            Setting setting = _context.Settings.FirstOrDefault();
            return View(setting);
        }
    }
}
