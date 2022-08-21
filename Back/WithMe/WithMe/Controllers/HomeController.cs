using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;
using WithMe.ViewModels;

namespace WithMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.pageintro = _context.Pageintros.FirstOrDefault();
            homeVM.ourstory = _context.Ourstroies.FirstOrDefault();
            homeVM.forsentence = _context.ForSentences.FirstOrDefault();
            homeVM.forspeacial = _context.ForSpecials.ToList();
            homeVM.forbetweensection = _context.ForBetweenSections.ToList();
            homeVM.homepagemenu = _context.HomePageMenus.ToList();
            homeVM.forsecondbetweensection = _context.ForSecondBetweenSections.FirstOrDefault();
            homeVM.forpartner = _context.ForPartners.FirstOrDefault();
            homeVM.forthirdbetweensection = _context.ForThirdBetweenSections.FirstOrDefault();


            return View(homeVM);
        }
    }
}
