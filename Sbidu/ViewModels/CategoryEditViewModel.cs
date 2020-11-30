using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.ViewModels
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        public IFormFile Upload { get; set; }
    }
}
