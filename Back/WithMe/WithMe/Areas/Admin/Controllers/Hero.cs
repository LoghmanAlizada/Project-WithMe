using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Hero : Controller
    {
        private readonly AppDbContext _context;
        public Hero(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PageIntro pageIntro = _context.Pageintros.FirstOrDefault();
            return View(pageIntro);
        }

        public IActionResult Update()
        {
            PageIntro dbPageIntro = _context.Pageintros.FirstOrDefault();
            if (dbPageIntro == null) return NotFound();

            return View(dbPageIntro);
        }

        [HttpPost]
        public IActionResult Update(PageIntro pageIntro)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            PageIntro dbPageIntro = _context.Pageintros.FirstOrDefault();
            if (dbPageIntro == null) return NotFound();

            dbPageIntro.Title = pageIntro.Title;
            dbPageIntro.Description = pageIntro.Description;
            _context.SaveChanges();
            return RedirectToAction("Index", "Hero");
        }

        
    }
}
