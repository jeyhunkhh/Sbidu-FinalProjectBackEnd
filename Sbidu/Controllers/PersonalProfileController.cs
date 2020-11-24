using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sbidu.Data;
using Sbidu.Helper;
using Sbidu.Models;

namespace Sbidu.Controllers
{
    [Authorize()]
    public class PersonalProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IFileManager _fileManager;
        private readonly ApplicationDbContext _context;

        public PersonalProfileController(UserManager<AppUser> userManager,
                                         IFileManager fileManager,
                                         ApplicationDbContext context)
        {
            _userManager = userManager;
            _fileManager = fileManager;
            _context = context;
        }

        [Route("personal-profile")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [Route("personal-profile/profil-details-edit")]
        public async Task<IActionResult> ProfilDetailsEdit()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        [Route("personal-profile/profil-details-edit")]
        public async Task<IActionResult> ProfilDetailsEdit(string id, [Bind("Photo,Upload,FullName,Id")]  AppUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if(user.Upload != null)
            {
                if (user.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1MB.");
                    return View(user);
                }
            }

            if(ModelState.IsValid)
            {
                if (user.Upload != null)
                {
                    if (activeUser.Photo != "user-1.jpg")
                    {
                        var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", user.Photo);
                        _fileManager.Delete(oldFile);
                    }
                    var fileName = _fileManager.Upload(user.Upload);
                    activeUser.Photo = fileName;
                }

                activeUser.FullName = user.FullName;

                await _userManager.UpdateAsync(activeUser);

                
                return RedirectToAction("index");
            }

            return View();
        }
    }
}
