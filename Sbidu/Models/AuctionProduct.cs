using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Models
{
    public class AuctionProduct
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(1000)]
        public string About { get; set; }
        [NotMapped]
        public List<IFormFile> Upload { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<AuctionProductGallery> AuctionProductGalleries { get; set; }
    }
}
