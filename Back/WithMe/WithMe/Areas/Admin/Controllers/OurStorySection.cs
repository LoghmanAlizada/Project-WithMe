using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurStorySection : Controller
    {
        private readonly AppDbContext _context;
        public OurStorySection(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            OurStory dbOurStory = _context.Ourstroies.FirstOrDefault();
            return View(dbOurStory);
        }

        public IActionResult Update()
        {
            OurStory dbOurStory = _context.Ourstroies.FirstOrDefault();
            if (dbOurStory == null) return NotFound();

            return View(dbOurStory);
        }

        [HttpPost]
        public IActionResult Update(OurStory ourStory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            OurStory dbOurStory = _context.Ourstroies.FirstOrDefault();
            if (dbOurStory == null) return NotFound();

            dbOurStory.SpanText = ourStory.SpanText;
            dbOurStory.Title = ourStory.Title;
            dbOurStory.Text = ourStory.Text;
            _context.SaveChanges();
            return RedirectToAction("Index", "OurStorySection");
        }
    }
}
