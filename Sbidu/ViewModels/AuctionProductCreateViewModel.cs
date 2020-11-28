using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewModels
{
    public class AuctionProductCreateViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(1000)]
        public string About { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int BuyNowPrice { get; set; }
        [Required]
        public int StartPrice { get; set; }
        public bool Popular { get; set; }
        public int CategoryId { get; set; }

        public IFormFile[] Uploads { get; set; }
    }
}
