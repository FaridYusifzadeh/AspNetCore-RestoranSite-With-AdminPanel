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
    public class Order_giftController : Controller
    {
        private Pato_PalaceDbContext _context;
        private IHostingEnvironment _env;

        public Order_giftController(Pato_PalaceDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Order_gifts);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Order_gift order = await _context.Order_gifts.FindAsync(id);

            if (order == null) return NotFound();

            return View(order);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order_gift order)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                 || ModelState["SubTitle"].ValidationState == ModelValidationState.Invalid
                  || ModelState["Description"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!order.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }
            if (!order.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }


            string filename = await order.Photo.CopyImage(_env.WebRootPath, "slider");

            order.Image = filename;
            await _context.Order_gifts.AddAsync(order);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Order_gift order = await _context.Order_gifts.FindAsync(id);

            if (order == null) return NotFound();

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Order_gift order = await _context.Order_gifts.FindAsync(id);
            if (order == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Utility.DeleteImgFromFolder(_env.WebRootPath, order.Image);

            _context.Order_gifts.Remove(order);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Order_gift order = await _context.Order_gifts.FindAsync(id);
            if (order == null) return NotFound();
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Order_gift order)
        {
            Order_gift orderDb = await _context.Order_gifts.FindAsync(id);

            if (orderDb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
               )
            {
                return View(orderDb);
            }

            if (order.PhotoUpdate != null)
            {
                if (!order.PhotoUpdate.IsImage())
                {
                    ModelState.AddModelError("Photo", "Content type must be image");
                    return View();
                }

                if (!order.PhotoUpdate.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Image size not more than 2 Mb");
                    return View();
                }

                string filename = await order.PhotoUpdate.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImgFromFolder(_env.WebRootPath, orderDb.Image);

                orderDb.Image = filename;
            }

            orderDb.Title = order.Title;
            orderDb.SubTitle = order.SubTitle;
            orderDb.Description = order.Description;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}