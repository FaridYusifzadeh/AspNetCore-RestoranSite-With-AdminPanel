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
    public class Photo_MenuController : Controller
    {
        private Pato_PalaceDbContext _context;
        private IHostingEnvironment _env;
        public Photo_MenuController(Pato_PalaceDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Photo_Menus);
        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Photo_Menu photo = await _context.Photo_Menus.FindAsync(id);

            if (photo == null) return NotFound();

            return View(photo);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Photo_Menu photo)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!photo.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }
            if (!photo.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }


            string filename = await photo.Photo.CopyImage(_env.WebRootPath, "slider");

            photo.Image = filename;
            await _context.Photo_Menus.AddAsync(photo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Photo_Menu photo = await _context.Photo_Menus.FindAsync(id);

            if (photo == null) return NotFound();

            return View(photo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Photo_Menu photo = await _context.Photo_Menus.FindAsync(id);
            if (photo == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Utility.DeleteImgFromFolder(_env.WebRootPath, photo.Image);

            _context.Photo_Menus.Remove(photo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Photo_Menu photo = await _context.Photo_Menus.FindAsync(id);
            if (photo == null) return NotFound();
            return View(photo);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Photo_Menu photo)
        {
            Photo_Menu photoDb = await _context.Photo_Menus.FindAsync(id);

            if (photoDb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid 
               )
            {
                return View(photoDb);
            }

            if (photo.PhotoUpdate != null)
            {
                if (!photo.PhotoUpdate.IsImage())
                {
                    ModelState.AddModelError("Photo", "Content type must be image");
                    return View();
                }

                if (!photo.PhotoUpdate.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Image size not more than 2 Mb");
                    return View();
                }

                string filename = await photo.PhotoUpdate.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImgFromFolder(_env.WebRootPath, photoDb.Image);

                photoDb.Image = filename;
            }

            photoDb.Title = photo.Title;
            
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}