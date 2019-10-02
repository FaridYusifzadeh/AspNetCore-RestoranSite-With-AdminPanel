using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Enjoy
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bos Saxlamayin")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile PhotoUpdate { get; set; }
    }
}
