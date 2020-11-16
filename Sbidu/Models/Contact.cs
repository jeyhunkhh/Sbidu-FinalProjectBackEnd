using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sbidu.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
