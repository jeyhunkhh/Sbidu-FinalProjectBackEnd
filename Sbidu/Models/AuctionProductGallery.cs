using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Models
{
    public class AuctionProductGallery
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public int AuctionProductId { get; set; }
        public AuctionProduct AuctionProduct { get; set; }

    }
}
