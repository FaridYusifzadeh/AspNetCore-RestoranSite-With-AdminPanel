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
    public class Menu_ContentController : Controller
    {
        private Pato_PalaceDbContext _context;

        public Menu_ContentController(Pato_PalaceDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Menu_Contents);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Menu_Content menu = await _context.Menu_Contents.FindAsync(id);

            if (menu == null) return NotFound();

            return View(menu);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Menu_Content menu)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Menu_Contents.AddAsync(menu);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Menu_Content menu = await _context.Menu_Contents.FindAsync(id);
            if (menu == null) return NotFound();
            return View(menu);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Menu_Content menu = await _context.Menu_Contents.FindAsync(id);
            _context.Menu_Contents.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Menu_Content menu = await _context.Menu_Contents.FindAsync(id);
            if (menu == null) return NotFound();
            return View(menu);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Menu_Content menu)
        {
            if (!ModelState.IsValid)
            {
                return View(menu);
            }

       
            _context.Entry(menu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



    }
}