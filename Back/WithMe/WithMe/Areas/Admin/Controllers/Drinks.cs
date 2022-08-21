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
    public class Drinks : Controller
    {
            private readonly AppDbContext _context;
            private readonly IWebHostEnvironment _env;
            public Drinks(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }

            public IActionResult Index()
            {
                List<DrinksSectionForThirdMenu> dbDrinks = _context.DrinksSectionForThirdMenus.ToList();
                return View(dbDrinks);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create(DrinksSectionForThirdMenu drinks)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (!drinks.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Accept Only Image!");
                    return View();
                }
                if (drinks.Photo.Length / 1024 > 10000)
                {
                    ModelState.AddModelError("Photo", "High Image Size!");
                    return View();
                }

                string path = _env.WebRootPath;
                string fileName = Guid.NewGuid().ToString() + drinks.Photo.FileName;
                string result = Path.Combine(path, "assets", "images", fileName);

                using (FileStream stream = new FileStream(result, FileMode.Create))
                {
                    await drinks.Photo.CopyToAsync(stream);
                };

                DrinksSectionForThirdMenu newDrinks = new DrinksSectionForThirdMenu();
                newDrinks.ImageURL = fileName;
                newDrinks.Name = drinks.Name;
                newDrinks.Price = drinks.Price;

                await _context.DrinksSectionForThirdMenus.AddAsync(newDrinks);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Desserts");
            }

            public async Task<IActionResult> Update(int? id)
            {
                if (id == null) return NotFound();
                DrinksSectionForThirdMenu dbDrinks = await _context.DrinksSectionForThirdMenus.FindAsync(id);
                if (dbDrinks == null) return NotFound();

                return View(dbDrinks);
            }

            [HttpPost]
            public async Task<IActionResult> Update(int? id, DrinksSectionForThirdMenu drinks)
            {
                if (id == null) return NotFound();
                DrinksSectionForThirdMenu dbDessert = await _context.DrinksSectionForThirdMenus.FindAsync(id);
                if (dbDessert == null) return NotFound();

                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (!drinks.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Accept Only Image!");
                    return View();
                }
                if (drinks.Photo.Length / 1024 > 10000)
                {
                    ModelState.AddModelError("Photo", "High Image Size!");
                    return View();
                }

                string path = _env.WebRootPath;
                string fileName = Guid.NewGuid().ToString() + drinks.Photo.FileName;
                string result = Path.Combine(path, "assets", "images", fileName);

                using (FileStream stream = new FileStream(result, FileMode.Create))
                {
                    await drinks.Photo.CopyToAsync(stream);
                };

                dbDessert.ImageURL = fileName;
                dbDessert.Name = drinks.Name;
                dbDessert.Price = drinks.Price;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Desserts");
            }

            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null) return NotFound();
                DrinksSectionForThirdMenu dbDrinks = await _context.DrinksSectionForThirdMenus.FindAsync(id);
                if (id == null) return NotFound();

                _context.DrinksSectionForThirdMenus.Remove(dbDrinks);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Desserts");
            }
    }
}
