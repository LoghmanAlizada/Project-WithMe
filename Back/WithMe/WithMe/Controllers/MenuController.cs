 using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;
using WithMe.ViewModels;

namespace WithMe.Controllers
{
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;
        public MenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            MenuVM menuVM = new MenuVM();
            menuVM.titlesectionformenupage = _context.TitleSectionForMenuPages.FirstOrDefault();
            menuVM.maincoursessectionformenupage = _context.MainCoursesSectionForMenuPages.ToList();
            menuVM.drinkssectionformenupages = _context.DrinksSectionForMenuPages.ToList();
            menuVM.dessertsectionformenupages = _context.DessertsSectionForMenuPages.ToList();

            return View(menuVM);
        }
    }
}
