using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Chef : Controller
    {
        private readonly AppDbContext _context;
        public Chef(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ChefPage> dbChef = _context.ChefPages.ToList();
            return View(dbChef);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            ChefPage dbChef = await _context.ChefPages.FindAsync(id);
            if (dbChef == null) return NotFound();

            return View(dbChef);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, ChefPage chef)
        {
            if (id == null) return NotFound();
            ChefPage dbChef = await _context.ChefPages.FindAsync(id);
            if (dbChef == null) return NotFound();

            dbChef.Name = chef.Name;
            dbChef.Position = chef.Position;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Chef");
        }
    }
}
