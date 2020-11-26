using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sbidu.Data;
using Sbidu.Helper;
using Sbidu.Models;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    [Authorize()]
    public class PersonalProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IFileManager _fileManager;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public PersonalProfileController(UserManager<AppUser> userManager,
                                         IFileManager fileManager,
                                         ApplicationDbContext context,
                                         SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _fileManager = fileManager;
            _context = context;
            _signInManager = signInManager;
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
        public async Task<IActionResult> ProfilDetailsEdit(string id, [Bind("Photo,Upload,FullName,UserName,Id")] AppUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Upload != null)
            {
                if (user.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1MB.");
                    return View(user);
                }

                if (activeUser.Photo != "user-1.jpg")
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", user.Photo);
                    _fileManager.Delete(oldFile);
                }
                var fileName = _fileManager.Upload(user.Upload);
                activeUser.Photo = fileName;
            }



            if (ModelState.IsValid)
            {
                if (user.UserName != activeUser.UserName)
                {
                    if(user.UserName == null)
                    {
                        ModelState.AddModelError("UserName", "The UserName field is required.");
                        return View(user);
                    }

                    AppUser existUser = _userManager.Users.FirstOrDefault(x => x.UserName == user.UserName);
                    if (existUser != null)
                    {
                        ModelState.AddModelError("UserName", "This username exists");
                        return View(user);
                    }

                    await _signInManager.SignInAsync(user, true);
                }

                activeUser.FullName = user.FullName;
                activeUser.UserName = user.UserName;

                await _userManager.UpdateAsync(activeUser);


                return RedirectToAction("index");
            }

            return View();
        }

        [Route("personal-profile/email-edit")]
        public async Task<IActionResult> EmailEdit()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        [Route("personal-profile/email-edit")]
        public async Task<IActionResult> EmailEdit(string id, [Bind("Email,Id")] AppUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.Email == null)
            {
                ModelState.AddModelError("Email", "The Email field is required.");
                return View(user);
            }

            if (user.Email != activeUser.Email)
            {
                AppUser existUser = _userManager.Users.FirstOrDefault(x => x.Email == user.Email);
                if (existUser != null)
                {
                    ModelState.AddModelError("Email", "This email exists");
                    return View(user);
                }
            }

            activeUser.Email = user.Email;
            await _userManager.UpdateAsync(activeUser);
            return RedirectToAction("index");
        }

        [Route("personal-profile/password-edit")]
        public IActionResult PasswordEdit()
        {
            return View();
        }

        [HttpPost]
        [Route("personal-profile/password-edit")]
        public async Task<IActionResult> PasswordEdit(ChangePasswordViewModel model)
        {
            var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var activeUserPassword = await _userManager.GeneratePasswordResetTokenAsync(activeUser);

            if (Crypto.VerifyHashedPassword(activeUser.PasswordHash, model.OldPassword))
            {
                if(model.OldPassword == model.Password)
                {
                    ModelState.AddModelError("Password", "The password cannot be the same as the old password");
                    return View(model);
                }
                IdentityResult identityResult = await _userManager.ResetPasswordAsync(activeUser, activeUserPassword, model.Password);

                if (!identityResult.Succeeded)
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("OldPassword", "The password is incorrect.");
                return View(model);
            }
        }
    }
}