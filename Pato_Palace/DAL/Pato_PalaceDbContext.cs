using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pato_Palace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pato_Palace.DAL
{
    public class Pato_PalaceDbContext: IdentityDbContext<AppUser>
    {
        public Pato_PalaceDbContext(DbContextOptions<Pato_PalaceDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<UniqueHistory> UniqueHistories { get; set; }
        public DbSet<Photo_Menu> Photo_Menus { get; set; }
        public DbSet<Main_Menu> Main_Menus { get; set; }
        public DbSet<Menu_Content> Menu_Contents { get; set; }
        public DbSet<Enjoy> Enjoys { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Rservation_Content> Rservation_Contents { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order_gift> Order_gifts { get; set; }
        public DbSet<ShopNowProduct> ShopNowProducts { get; set; }
        public DbSet<Buscket> Busckets { get; set; }



    }
}
