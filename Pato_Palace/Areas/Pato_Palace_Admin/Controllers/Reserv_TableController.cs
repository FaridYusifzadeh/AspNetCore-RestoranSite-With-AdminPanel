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
    public class Reserv_TableController : Controller
    {
        private Pato_PalaceDbContext _context;

        public Reserv_TableController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Reserv_Tables);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

           
            Reserv_Table reserv = await _context.Reserv_Tables.FindAsync(id);

            if (reserv == null) return NotFound();

            return View(reserv);

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Reserv_Table reserv = await _context.Reserv_Tables.FindAsync(id);
            if (reserv == null) return NotFound();
            return View(reserv);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Reserv_Table reserv = await _context.Reserv_Tables.FindAsync(id);
            _context.Reserv_Tables.Remove(reserv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Reserv_Table reserv = await _context.Reserv_Tables.FindAsync(id);
            if (reserv == null) return NotFound();
            return View(reserv);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Reserv_Table reserv)
        {
            if (!ModelState.IsValid)
            {
                return View(reserv);
            }


            _context.Entry(reserv).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}