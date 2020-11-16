using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(30)]
        public string FaxPhone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
