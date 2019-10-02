using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Pato_Palace.DAL;
using Pato_Palace.Extentions;
using Pato_Palace.Models;
using Pato_Palace.Utilities;

namespace Pato_Palace.Areas.Pato_Palace_Admin.Controllers
{
    [Area("Pato_Palace_Admin")]
    public class EnjoyController : Controller
    {
        private Pato_PalaceDbContext _context;
        private IHostingEnvironment _env;

        public EnjoyController(Pato_PalaceDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Enjoys);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Enjoy enjoy = await _context.Enjoys.FindAsync(id);

            if (enjoy == null) return NotFound();

            return View(enjoy);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Enjoy enjoy)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!enjoy.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }
            if (!enjoy.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }


            string filename = await enjoy.Photo.CopyImage(_env.WebRootPath, "slider");

            enjoy.Image = filename;
            await _context.Enjoys.AddAsync(enjoy);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Enjoy enjoy = await _context.Enjoys.FindAsync(id);

            if (enjoy == null) return NotFound();

            return View(enjoy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Enjoy enjoy = await _context.Enjoys.FindAsync(id);
            if (enjoy == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Utility.DeleteImgFromFolder(_env.WebRootPath, enjoy.Image);

            _context.Enjoys.Remove(enjoy);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Enjoy enjoy = await _context.Enjoys.FindAsync(id);
            if (enjoy == null) return NotFound();
            return View(enjoy);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Enjoy enjoy)
        {
            Enjoy enjoyDb = await _context.Enjoys.FindAsync(id);

            if (enjoyDb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
               )
            {
                return View(enjoyDb);
            }

            if (enjoy.PhotoUpdate != null)
            {
                if (!enjoy.PhotoUpdate.IsImage())
                {
                    ModelState.AddModelError("Photo", "Content type must be image");
                    return View();
                }

                if (!enjoy.PhotoUpdate.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Image size not more than 2 Mb");
                    return View();
                }

                string filename = await enjoy.PhotoUpdate.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImgFromFolder(_env.WebRootPath, enjoyDb.Image);

                enjoyDb.Image = filename;
            }

            enjoyDb.Title = enjoy.Title;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}