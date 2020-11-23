using Sbidu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewModels
{
    public class MyProfileViewModel
    {
        public List<AuctionProduct> AuctionProduct { get; set; }
        public List<UserAuctionProduct> UserAuctionProducts { get; set; }
        public AppUser AppUser { get; set; }
    }
}
