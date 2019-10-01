using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pato_Palace.DAL;
using Pato_Palace.ViewModels;

namespace Pato_Palace.Controllers
{
    public class HomeController : Controller
    {
        private Pato_PalaceDbContext _context;
        public HomeController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel
            {
                Sliders=_context.Sliders,
                UniqueHistories=_context.UniqueHistories,
                Photo_Menus=_context.Photo_Menus,
                Main_Menus=_context.Main_Menus,
                Menu_Contents=_context.Menu_Contents,
                Enjoys=_context.Enjoys,
                Reservations=_context.Reservations,
                Rservation_Contents=_context.Rservation_Contents,
                Locations=_context.Locations,
                Order_gifts=_context.Order_gifts
            };
            return View(homeModel);
        }
    }
}