using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sbidu.Controllers
{
    public class PersonalProfileController : Controller
    {
        [Route("personal-profile")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
