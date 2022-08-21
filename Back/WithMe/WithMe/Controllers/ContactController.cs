using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.ViewModels;

namespace WithMe.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM();
            contactVM.contactpage = _context.ContactPages.FirstOrDefault();
            contactVM.socialmediaaccount = _context.SocialMediaAccounts.ToList();
            return View(contactVM);
        }
    }
}
