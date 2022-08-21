using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.ViewModels;

namespace WithMe.Controllers
{
    public class SecondMenuController : Controller
    {
        private readonly AppDbContext _context;
        public SecondMenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            SecondMenuVM secondMenuVM = new SecondMenuVM();
            secondMenuVM.titlesectionforsecondmenupage = _context.TitleSectionForSecondMenuPages.FirstOrDefault();
            secondMenuVM.maincoursessectionforsecondmenu = _context.MainCoursesSectionForSecondMenus.ToList();
            secondMenuVM.dessertssectionforsecondmenu = _context.DessertsSectionForSecondMenus.ToList();
            secondMenuVM.drinkssectionforsecondmenu = _context.DrinksSectionForSecondMenus.ToList();
            secondMenuVM.coffeessectionforsecondmenu = _context.CoffeesSectionForSecondMenu.ToList();

            return View(secondMenuVM);
        }
    }
}
