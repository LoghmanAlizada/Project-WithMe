using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThirdBetween : Controller
    {
        public readonly AppDbContext _context;
        public ThirdBetween(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ForSecondBetweenSection forSecondBetweenSection = _context.ForSecondBetweenSections.FirstOrDefault();
            if(forSecondBetweenSection == null) return NotFound();
            return View(forSecondBetweenSection);
        }

        public IActionResult Update()
        {
            ForSecondBetweenSection dbforSecondBetweenSection = _context.ForSecondBetweenSections.FirstOrDefault();
            if(dbforSecondBetweenSection == null) return NotFound();
            return View(dbforSecondBetweenSection);
        }

        [HttpPost]
        public IActionResult Update(ForSecondBetweenSection forSecondBetweenSection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ForSecondBetweenSection dbforSecondBetweenSection = _context.ForSecondBetweenSections.FirstOrDefault();
            if (dbforSecondBetweenSection == null) return NotFound();

            dbforSecondBetweenSection.Title = forSecondBetweenSection.Title;
            dbforSecondBetweenSection.WeekDaysTime = forSecondBetweenSection.WeekDaysTime;
            dbforSecondBetweenSection.WeekEndTime = forSecondBetweenSection.WeekEndTime;
            _context.SaveChanges();

            return RedirectToAction("Index", "ThirdBetween");
        }
    }
}
