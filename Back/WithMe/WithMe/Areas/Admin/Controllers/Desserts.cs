using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;
using WithMe.ViewModels;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Desserts : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public Desserts(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int take = 5, int pageSize = 1)
        {
            ViewBag.takeSize2 = take;
            List<DessertsSectionForThirdMenu> dbDesserts = _context.DessertsSectionForThirdMenus.Skip((pageSize - 1) * take).Take(take).ToList();
            Pagination<DessertsSectionForThirdMenu> pagination = new Pagination<DessertsSectionForThirdMenu>
            (
                ReturnPageCount(take),
                pageSize,
                dbDesserts
            );

            return View(pagination);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DessertsSectionForThirdMenu desserts)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!desserts.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Accept Only Image!");
                return View();
            }
            if (desserts.Photo.Length / 1024 > 10000)
            {
                ModelState.AddModelError("Photo", "High Image Size!");
                return View();
            }

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + desserts.Photo.FileName;
            string result = Path.Combine(path, "assets", "images", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await desserts.Photo.CopyToAsync(stream);
            };

            DessertsSectionForThirdMenu newDessert = new DessertsSectionForThirdMenu();
            newDessert.ImageURL = fileName;
            newDessert.Name = desserts.Name;
            newDessert.Price = desserts.Price;

            await _context.DessertsSectionForThirdMenus.AddAsync(newDessert);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Desserts");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            DessertsSectionForThirdMenu dbDessert = await _context.DessertsSectionForThirdMenus.FindAsync(id);
            if(dbDessert == null) return NotFound();

            return View(dbDessert);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, DessertsSectionForThirdMenu desserts)
        {
            if (id == null) return NotFound();
            DessertsSectionForThirdMenu dbDessert = await _context.DessertsSectionForThirdMenus.FindAsync(id);
            if (dbDessert == null) return NotFound();

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!desserts.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Accept Only Image!");
                return View();
            }
            if (desserts.Photo.Length / 1024 > 10000)
            {
                ModelState.AddModelError("Photo", "High Image Size!");
                return View();
            }

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + desserts.Photo.FileName;
            string result = Path.Combine(path, "assets", "images", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await desserts.Photo.CopyToAsync(stream);
            };

            dbDessert.ImageURL = fileName;
            dbDessert.Name = desserts.Name;
            dbDessert.Price = desserts.Price;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Desserts");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            DessertsSectionForThirdMenu dbDessert = await _context.DessertsSectionForThirdMenus.FindAsync(id);
            if (id == null) return NotFound();

            _context.DessertsSectionForThirdMenus.Remove(dbDessert);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Desserts");
        }

        private int ReturnPageCount(int take)
        {
            int menuCount = _context.DessertsSectionForThirdMenus.Count();
            return (int)Math.Ceiling((decimal)menuCount / take) + 1;
        }
    }
}
