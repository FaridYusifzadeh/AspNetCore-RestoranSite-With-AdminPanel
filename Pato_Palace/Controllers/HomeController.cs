using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pato_Palace.DAL;
using Pato_Palace.Models;
using Pato_Palace.ViewModels;

namespace Pato_Palace.Controllers
{
    public class HomeController : Controller
    {
        private Pato_PalaceDbContext _context;

        //public static HomeModel homemodel ;
        HomeModel homeModel;


        public HomeController(Pato_PalaceDbContext context)
        {
            _context = context;
             homeModel = new HomeModel
            {
                Sliders = _context.Sliders,
                UniqueHistories = _context.UniqueHistories,
                Photo_Menus = _context.Photo_Menus,
                Main_Menus = _context.Main_Menus,
                Menu_Contents = _context.Menu_Contents,
                Enjoys = _context.Enjoys,
                Reservations = _context.Reservations,
                Rservation_Contents = _context.Rservation_Contents,
                Locations = _context.Locations,
                Order_gifts = _context.Order_gifts,
                ShopNowProducts = _context.ShopNowProducts,
                Busckets=_context.Busckets
            };

        }
        public IActionResult Index()
        {
            


            return View(homeModel);
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult OurChefs()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult Locations()
        {
            return View();
        }
        public ActionResult Reservation()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public IActionResult ShopNow  ()
        {
            
            return View(homeModel);
        }

        public async Task<IActionResult> BuyNow(int? id)
        {
            if (id == null) return NotFound();
            ShopNowProduct shopNowProduct = await _context.ShopNowProducts.FindAsync(id);

            if (shopNowProduct != null)
            {
                return View(shopNowProduct);
            }

            return NotFound();
        }
    }
}