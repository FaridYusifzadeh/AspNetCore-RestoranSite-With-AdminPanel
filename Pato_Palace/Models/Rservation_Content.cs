using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Rservation_Content
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(150)]
       
        public string Description { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Bos Saxlamayin")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile PhotoUpdate { get; set; }
    }
}
