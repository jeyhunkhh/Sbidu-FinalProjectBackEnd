using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sbidu.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }

        public List<UserAuctionProduct> UserAuctionProducts { get; set; }
    }
}
