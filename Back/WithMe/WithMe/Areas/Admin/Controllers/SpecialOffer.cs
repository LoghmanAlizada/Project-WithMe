using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialOffer : Controller
    {
        private readonly AppDbContext _context;
        public SpecialOffer(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ForSpecial> forSpecial = _context.ForSpecials.ToList();
            return View(forSpecial);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            ForSpecial dbSpecial = await _context.ForSpecials.FindAsync(id);
            if (dbSpecial == null) return NotFound();
            return View(dbSpecial);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, ForSpecial forSpecial)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();
            ForSpecial dbSpecial = await _context.ForSpecials.FindAsync(id);
            if (dbSpecial == null) return NotFound();
            if (forSpecial == null) return NotFound();

            dbSpecial.SpanText = forSpecial.SpanText;
            dbSpecial.Title = forSpecial.Title;
            dbSpecial.IconURL = forSpecial.IconURL;
            dbSpecial.CardTitle = forSpecial.CardTitle;
            dbSpecial.CardDescription = forSpecial.CardDescription;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index","SpecialOffer");
        }
    }
}
