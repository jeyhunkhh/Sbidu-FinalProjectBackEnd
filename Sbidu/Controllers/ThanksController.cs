using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Controllers
{
    public class ThanksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
