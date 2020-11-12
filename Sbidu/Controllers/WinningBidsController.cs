using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sbidu.Controllers
{
    public class WinningBidsController : Controller
    {
        [Route("winning-bids")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
