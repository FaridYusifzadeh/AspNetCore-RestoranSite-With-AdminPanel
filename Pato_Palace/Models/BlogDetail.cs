using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required, StringLength(300)]
        public string Image { get; set; }
    }
}
