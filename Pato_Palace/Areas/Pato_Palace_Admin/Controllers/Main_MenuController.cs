using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pato_Palace.DAL;
using Pato_Palace.Models;

namespace Pato_Palace.Areas.Pato_Palace_Admin.Controllers
{
    [Area("Pato_Palace_Admin")]
    public class Main_MenuController : Controller
    {
        private Pato_PalaceDbContext _context;
        public Main_MenuController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Main_Menus);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Main_Menu mainmenu = await _context.Main_Menus.FindAsync(id);

            if (mainmenu == null) return NotFound();

            return View(mainmenu);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Main_Menu mainmenu)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Main_Menus.AddAsync(mainmenu);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Main_Menu mainmenu = await _context.Main_Menus.FindAsync(id);
            if (mainmenu == null) return NotFound();
            return View(mainmenu);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Main_Menu mainmenu = await _context.Main_Menus.FindAsync(id);
            _context.Main_Menus.Remove(mainmenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Main_Menu mainmenu = await _context.Main_Menus.FindAsync(id);
            if (mainmenu == null) return NotFound();
            return View(mainmenu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Main_Menu mainmenu)
        {
            if (!ModelState.IsValid)
            {
                return View(mainmenu);
            }


            _context.Entry(mainmenu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



    }
}