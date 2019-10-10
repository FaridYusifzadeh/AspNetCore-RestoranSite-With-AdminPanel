using Pato_Palace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<UniqueHistory> UniqueHistories { get; set; }
        public IEnumerable<Photo_Menu> Photo_Menus { get; set; }
        public IEnumerable<Main_Menu> Main_Menus { get; set; }
        public IEnumerable<Menu_Content> Menu_Contents { get; set; }
        public IEnumerable<Enjoy> Enjoys { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<Rservation_Content> Rservation_Contents { get; set; }
        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<Order_gift> Order_gifts { get; set; }
        public IEnumerable<ShopNowProduct> ShopNowProducts { get; set; }
        public IEnumerable<Buscket> Busckets { get; set; }


    }
}
