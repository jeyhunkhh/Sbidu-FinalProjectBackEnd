using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Models
{
    public class UserAuctionProduct
    {
        public int Id { get; set; }
        public int? Bid { get; set; }
        public bool IsFavorit { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsWinner { get; set; }
        public int? SoldPrice { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int AuctionProductId { get; set; }
        public AuctionProduct AuctionProduct { get; set; }

    }
}
