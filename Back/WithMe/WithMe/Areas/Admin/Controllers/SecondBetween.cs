using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SecondBetween : Controller
    {
        private readonly AppDbContext _context;
        public SecondBetween(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ForBetweenSection> forBetweenSection = _context.ForBetweenSections.ToList();
            return View(forBetweenSection);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if(id == null) return NotFound();
            ForBetweenSection dbBetweenSection = await _context.ForBetweenSections.FindAsync(id);
            if(dbBetweenSection == null) return NotFound();

            return View(dbBetweenSection);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, ForBetweenSection forBetweenSection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();
            ForBetweenSection dbBetweenSection = await _context.ForBetweenSections.FindAsync(id);
            if (dbBetweenSection == null) return NotFound();

            dbBetweenSection.Count = forBetweenSection.Count;
            dbBetweenSection.SpanText = forBetweenSection.SpanText;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "SecondBetween");
        }
    }
}
