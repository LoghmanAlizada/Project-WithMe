using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FirstBetween : Controller
    {
        private readonly AppDbContext _context;
        public FirstBetween(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ForSentence forSentence = _context.ForSentences.FirstOrDefault();
            return View(forSentence);
        }

        public IActionResult Update()
        {
            ForSentence dbForSentence = _context.ForSentences.FirstOrDefault();
            if (dbForSentence == null) return NotFound();

            return View(dbForSentence);
        }

        [HttpPost]
        public IActionResult Update(ForSentence forSentence)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ForSentence dbForSentence = _context.ForSentences.FirstOrDefault();
            if (dbForSentence == null) return NotFound();

            dbForSentence.TopSentence = forSentence.TopSentence;
            dbForSentence.BottomSentence = forSentence.BottomSentence;
            _context.SaveChanges();
            return RedirectToAction("Index", "FirstBetween");
        }
    }
}
