using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewModels
{
    public class HomeViewModel
    {
        public HomePoster HomePoster { get; set; }
        public List<AuctionProduct> AuctionProducts { get; set; }
        public List<Category> Categories { get; set; }
    }
}
