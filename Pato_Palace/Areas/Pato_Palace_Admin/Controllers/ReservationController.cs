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
    public class ReservationController : Controller
    {
        private Pato_PalaceDbContext _context;
        public ReservationController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Reservations);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Reservation reserv = await _context.Reservations.FindAsync(id);

            if (reserv == null) return NotFound();

            return View(reserv);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reserv)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Reservations.AddAsync(reserv);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Reservation reserv = await _context.Reservations.FindAsync(id);
            if (reserv == null) return NotFound();
            return View(reserv);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Reservation reserv = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reserv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Reservation reserv = await _context.Reservations.FindAsync(id);
            if (reserv == null) return NotFound();
            return View(reserv);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Reservation reserv)
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