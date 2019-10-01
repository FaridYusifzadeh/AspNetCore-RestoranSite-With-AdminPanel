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
    public class UniqueHistoryController : Controller
    {
        private Pato_PalaceDbContext _context;

        public UniqueHistoryController(Pato_PalaceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.UniqueHistories);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            UniqueHistory unique = await _context.UniqueHistories.FindAsync(id);

            if (unique == null) return NotFound();

            return View(unique);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UniqueHistory unique)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.UniqueHistories.AddAsync(unique);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            UniqueHistory unique = await _context.UniqueHistories.FindAsync(id);
            if (unique == null) return NotFound();
            return View(unique);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            UniqueHistory unique = await _context.UniqueHistories.FindAsync(id);
            _context.UniqueHistories.Remove(unique);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            UniqueHistory unique = await _context.UniqueHistories.FindAsync(id);
            if (unique == null) return NotFound();
            return View(unique);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, UniqueHistory unique)
        {
            if (!ModelState.IsValid)
            {
                return View(unique);
            }


            _context.Entry(unique).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}