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
    public class LocationController : Controller
    {
        private Pato_PalaceDbContext _context;
        public LocationController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Locations);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Location location = await _context.Locations.FindAsync(id);

            if (location == null) return NotFound();

            return View(location);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Location location)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Location location = await _context.Locations.FindAsync(id);
            if (location == null) return NotFound();
            return View(location);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Location location = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Location location = await _context.Locations.FindAsync(id);
            if (location == null) return NotFound();
            return View(location);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Location location)
        {
            if (!ModelState.IsValid)
            {
                return View(location);
            }


            _context.Entry(location).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}