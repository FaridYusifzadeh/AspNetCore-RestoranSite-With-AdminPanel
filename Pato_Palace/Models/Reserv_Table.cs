using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Reserv_Table
    {
        public int Id { get; set; }
      [Required]
        public string UserId { get; set; }
        [Required, StringLength(30)]
        public string Date { get; set; }
        [Required, StringLength(30)]
        public string Time { get; set; }
        [Required]
        public int Persone_Count { get; set; }
        [Required, StringLength(170)]
        public string Username { get; set; }
    }
}
