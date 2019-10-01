using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class UniqueHistory
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(550)]
        public string Description { get; set; }
        [Required, StringLength(255)]
        public string SubDescription { get; set; }
    }
}
