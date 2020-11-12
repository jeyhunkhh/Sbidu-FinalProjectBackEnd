using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sbidu.Models
{
    public class HomePoster
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public int Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(300)]
        public int Text { get; set; }
        [MaxLength(300)]
        public int Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
