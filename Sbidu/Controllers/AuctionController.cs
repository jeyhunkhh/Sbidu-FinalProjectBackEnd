using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sbidu.Controllers
{
    [Route("auction")]
    public class AuctionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
