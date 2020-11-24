using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sbidu.Models;
using Sbidu.ViewModels;
using System.Threading.Tasks;

namespace Sbidu.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong!");
                return View(login);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(user, login.Password, login.IsRemember, true);

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "The account is locked out 5 minute!");
                return View(login);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!");
                return View(login);
            }

            return RedirectToAction("index","home");
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                FullName = register.FullName,
                Email = register.Email,
                UserName = register.UserName,
                Photo = "user-1.jpg"
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }

            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index","Home");
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
