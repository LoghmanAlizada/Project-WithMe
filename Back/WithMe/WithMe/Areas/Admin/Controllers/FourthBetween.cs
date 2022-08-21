using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FourthBetween : Controller
    {
        private readonly AppDbContext _context;
        public FourthBetween(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ForThirdBetweenSection forThirdBetweenSection = _context.ForThirdBetweenSections.FirstOrDefault();
            if(forThirdBetweenSection == null) return NotFound();
            return View(forThirdBetweenSection);
        }

        public IActionResult Update()
        {
            ForThirdBetweenSection dbforThirdBetweenSection = _context.ForThirdBetweenSections.FirstOrDefault();
            if (dbforThirdBetweenSection == null) return NotFound();
            return View(dbforThirdBetweenSection);
        }

        [HttpPost]
        public IActionResult Update(ForThirdBetweenSection forThirdBetweenSection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ForThirdBetweenSection dbforThirdBetweenSection = _context.ForThirdBetweenSections.FirstOrDefault();
            if (dbforThirdBetweenSection == null) return NotFound();

            dbforThirdBetweenSection.TopSentence = forThirdBetweenSection.TopSentence;
            dbforThirdBetweenSection.BottomSentence = forThirdBetweenSection.BottomSentence;
            _context.SaveChanges();

            return RedirectToAction("Index", "FourthBetween");
        }
    }
}
