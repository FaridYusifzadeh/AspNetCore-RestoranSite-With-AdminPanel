using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pato_Palace.DAL;
using Pato_Palace.Models;
using Pato_Palace.ViewModels;
using System.Security.Claims;
using Pato_Palace.Controllers;
using Microsoft.AspNetCore.Identity;

namespace Pato_Palace.Controllers
{
    public class HomeController : Controller
    {
        private Pato_PalaceDbContext _context;
        public AppUser user;
        UserManager<AppUser> manager;
        //public static HomeModel homemodel ;
        HomeModel homeModel;


        public HomeController(Pato_PalaceDbContext context, UserManager<AppUser> userManager)
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
                Busckets = _context.Busckets,
                Reserv_Tables=_context.Reserv_Tables
            };
            manager = userManager;
        }


        public string getuser()
        {
            var user = manager.GetUserId(HttpContext.User);
            return user;
        }

        public IActionResult Index()
        {



            return View(homeModel);
        }
        public ActionResult AboutUs()
        {
            return View(homeModel);
        }

        public ActionResult Menu()
        {
            return View(homeModel);
        }

        public ActionResult OurChefs()
        {
            return View(homeModel);
        }
        public ActionResult Events()
        {
            return View(homeModel);
        }
        public ActionResult Locations()
        {
            return View(homeModel);
        }
        public ActionResult Reservation()
        {
            return View(homeModel);
        }

        public ActionResult Gallery()
        {
            return View(homeModel);
        }
        public ActionResult Blog()
        {
            return View(homeModel);
        }

        public ActionResult BlogDetail()
        {
            return View(homeModel);
        }

        public async Task<IActionResult> BlogReadmore(int? id)
        {
            if (id == null) return NotFound();
            List<ShopNowProduct> myproducts = new List<ShopNowProduct>();
            ShopNowProduct shopNowProduct = await _context.ShopNowProducts.FindAsync(id);

            if (shopNowProduct != null)
            {
                myproducts.Add(shopNowProduct);
                homeModel.ShopNowProducts = myproducts;

                return View(homeModel);
            }

            return NotFound();
        }

        public ActionResult ContactUs()
        {
            return View(homeModel);
        }
        public IActionResult ShopNow()
        {

            return View(homeModel);
        }



        public async Task<IActionResult> BuyNow(int? id)
        {
            if (id == null) return NotFound();
            List<ShopNowProduct> myproducts = new List<ShopNowProduct>();
            ShopNowProduct shopNowProduct = await _context.ShopNowProducts.FindAsync(id);

            if (shopNowProduct != null)
            {
                myproducts.Add(shopNowProduct);
                homeModel.ShopNowProducts = myproducts;

                return View(homeModel);
            }

            return NotFound();
        }


        public IActionResult Buscket()
        {
            var UserId = getuser();
            List<ShopNowProduct> myproducts = new List<ShopNowProduct>();
            var busket = _context.Busckets.Where(bus => bus.AppUserId == UserId);
            foreach (var i in busket)
            {
                var products = _context.ShopNowProducts.Find(i.ShopNowProductId);
                myproducts.Add(products);
            }

            homeModel.ShopNowProducts = myproducts;

            return View(homeModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuscketProduct(int? id,string count)
        {
            var UserId = getuser();
            List<ShopNowProduct> myproducts = new List<ShopNowProduct>();
            var busket = _context.Busckets.Where(bus => bus.AppUserId == UserId);

            if (id != null)
            {
                ShopNowProduct shopNowProduct = await _context.ShopNowProducts.FindAsync(id);


                if (!string.IsNullOrWhiteSpace(count))
                {
                    int cnt = int.Parse(count);
                    for (int i = 0; i < cnt; i++)
                    {
                        Buscket bs = new Buscket();

                        bs.ShopNowProductId = shopNowProduct.Id;
                        bs.AppUserId = UserId;

                        _context.Busckets.Add(bs);
                    }
                  
                }
               

                await _context.SaveChangesAsync();



                foreach (var i in busket)
                {
                    var products = _context.ShopNowProducts.Find(i.ShopNowProductId);
                    myproducts.Add(products);
                }

                homeModel.ShopNowProducts = myproducts;

                return View(homeModel);


            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ActionName("Delete")]
        public IActionResult DeleteProducts()
        {
            var UserId = getuser();


            var busket = _context.Busckets.Where(bus => bus.AppUserId == UserId);
            foreach (var i in busket)
            {

                _context.Busckets.Remove(i);
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Buscket));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProduct(string delete)
        {
            var UserId = getuser();


            var busket = _context.Busckets.Where(bus => bus.AppUserId == UserId);
            foreach (var i in busket)
            {
                if (i.ShopNowProductId == int.Parse(delete))
                {

                 _context.Busckets.Remove(i);
                    break;
                }
                
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Buscket));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReserv(string date, string time, string personCount)
        {
            var UserId = getuser();
            Reserv_Table res = new Reserv_Table();
            res.Date = date;
            res.Time = time;
            res.UserId = UserId;
            res.Persone_Count =int.Parse(personCount);
            _context.Reserv_Tables.Add(res);
            _context.SaveChanges();
            ViewBag.Msg = "Success";
            return View("Views/Home/Reservation.cshtml",homeModel);
        }


    }
}