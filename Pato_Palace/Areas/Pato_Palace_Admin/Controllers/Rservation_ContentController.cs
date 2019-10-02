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
    public class Rservation_ContentController : Controller
    {
        private Pato_PalaceDbContext _context;
        private IHostingEnvironment _env;
        public Rservation_ContentController(Pato_PalaceDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Rservation_Contents);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Rservation_Content rservationcontent = await _context.Rservation_Contents.FindAsync(id);

            if (rservationcontent == null) return NotFound();

            return View(rservationcontent);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Rservation_Content rservationcontent)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid || ModelState["Description"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!rservationcontent.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }
            if (!rservationcontent.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }


            string filename = await rservationcontent.Photo.CopyImage(_env.WebRootPath, "slider");

            rservationcontent.Image = filename;
            await _context.Rservation_Contents.AddAsync(rservationcontent);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Rservation_Content rservationcontent = await _context.Rservation_Contents.FindAsync(id);

            if (rservationcontent == null) return NotFound();

            return View(rservationcontent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Rservation_Content rservationcontent = await _context.Rservation_Contents.FindAsync(id);
            if (rservationcontent == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Utility.DeleteImgFromFolder(_env.WebRootPath, rservationcontent.Image);

            _context.Rservation_Contents.Remove(rservationcontent);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Rservation_Content rservationcontent = await _context.Rservation_Contents.FindAsync(id);
            if (rservationcontent == null) return NotFound();
            return View(rservationcontent);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Rservation_Content rservationcontent)
        {
            Rservation_Content rservationcontentDb = await _context.Rservation_Contents.FindAsync(id);

            if (rservationcontentDb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
               )
            {
                return View(rservationcontentDb);
            }

            if (rservationcontent.PhotoUpdate != null)
            {
                if (!rservationcontent.PhotoUpdate.IsImage())
                {
                    ModelState.AddModelError("Photo", "Content type must be image");
                    return View();
                }

                if (!rservationcontent.PhotoUpdate.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Image size not more than 2 Mb");
                    return View();
                }

                string filename = await rservationcontent.PhotoUpdate.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImgFromFolder(_env.WebRootPath, rservationcontentDb.Image);

                rservationcontentDb.Image = filename;
            }

            rservationcontentDb.Title = rservationcontent.Title;
            rservationcontentDb.Description = rservationcontent.Description;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }









    }
}