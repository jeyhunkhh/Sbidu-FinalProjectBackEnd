using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sbidu.Controllers
{
    public class ReferralsController : Controller
    {
        [Route("referrals")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
