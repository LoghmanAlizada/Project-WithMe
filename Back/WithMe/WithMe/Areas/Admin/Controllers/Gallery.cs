using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Gallery : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public Gallery(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<GalleryPage> dbGallery = _context.GalleryPages.ToList();
            return View(dbGallery);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GalleryPage gallery)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!gallery.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Accept Only Image!");
                return View();
            }
            if (gallery.Photo.Length / 1024 > 10000)
            {
                ModelState.AddModelError("Photo", "High Image Size!");
                return View();
            }

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + gallery.Photo.FileName;
            string result = Path.Combine(path, "assets", "images", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await gallery.Photo.CopyToAsync(stream);
            };

            GalleryPage newGallery = new GalleryPage();
            newGallery.ImageURL = fileName;

            await _context.GalleryPages.AddAsync(newGallery);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Gallery");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            GalleryPage dbGallery = await _context.GalleryPages.FindAsync(id);
            if (dbGallery == null) return NotFound();

            _context.GalleryPages.Remove(dbGallery);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Gallery");
        }
    }
}
