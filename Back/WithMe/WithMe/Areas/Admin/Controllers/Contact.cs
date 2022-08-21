using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Contact : Controller
    {
        private readonly AppDbContext _context;
        public Contact(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ContactPage contactPage = _context.ContactPages.FirstOrDefault();
            if (contactPage == null) return NotFound();
            return View(contactPage);
        }

        public IActionResult Update()
        {
            ContactPage dbContactPage = _context.ContactPages.FirstOrDefault();
            if (dbContactPage == null) return NotFound();

            return View(dbContactPage);
        }

        [HttpPost]
        public IActionResult Update(ContactPage contactPage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ContactPage dbContactPage = _context.ContactPages.FirstOrDefault();
            if (dbContactPage == null) return NotFound();

            dbContactPage.Location = contactPage.Location;
            dbContactPage.Mail = contactPage.Mail;
            dbContactPage.WeekTime = contactPage.WeekTime;
            dbContactPage.WeekendTime = contactPage.WeekendTime;

            _context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}
