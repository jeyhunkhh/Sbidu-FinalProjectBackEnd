using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sbidu.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(100)]
        public string Facebook { get; set; }
        [Required]
        [MaxLength(100)]
        public string Instagram { get; set; }
        [Required]
        [MaxLength(100)]
        public string Twitter { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
