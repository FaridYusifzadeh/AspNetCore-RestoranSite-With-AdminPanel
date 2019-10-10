using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.Models
{
    public class Buscket
    {
        public int Id { get; set; }

        public int? AppUserId { get; set; }
        public AppUser AppUsers { get; set; }

        public int? ShopNowProductId { get; set; }
        public ShopNowProduct ShopNowProducts { get; set; }


    }
}
