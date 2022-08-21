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
    public class MenuforHomePage : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;
        public MenuforHomePage(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<HomePageMenu> homePageMenu = _context.HomePageMenus.ToList();
            return View(homePageMenu);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            HomePageMenu dbhomePageMenu = await _context.HomePageMenus.FindAsync(id);
            if (dbhomePageMenu == null) return NotFound();
            return View(dbhomePageMenu);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, HomePageMenu homePageMenu)
        {
            if (id == null) return NotFound();
            HomePageMenu dbhomePageMenu = await _context.HomePageMenus.FindAsync(id);
            if (dbhomePageMenu == null) return NotFound();

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!homePageMenu.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Accept Only Image!");
                return View();
            }
            if (homePageMenu.Photo.Length / 1024 > 10000)
            {
                ModelState.AddModelError("Photo", "High Image Size!");
                return View();
            }

            string path = _env.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + homePageMenu.Photo.FileName;
            string result = Path.Combine(path, "assets", "images", fileName);

            using (FileStream stream = new FileStream(result, FileMode.Create))
            {
                await homePageMenu.Photo.CopyToAsync(stream);
            };

            dbhomePageMenu.ImageURL = fileName;
            dbhomePageMenu.Title = homePageMenu.Title;
            dbhomePageMenu.ButtonText = homePageMenu.ButtonText;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "MenuforHomePage");

        }
    }
}
