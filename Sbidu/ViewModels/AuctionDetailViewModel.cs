using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewModels
{
    public class AuctionDetailViewModel
    {
        public AuctionProduct AuctionProduct { get; set; }
        public List<Faq> Faq { get; set; }

        public int Bid { get; set; }
    }
}
