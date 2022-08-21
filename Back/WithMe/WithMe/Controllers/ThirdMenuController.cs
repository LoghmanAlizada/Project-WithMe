using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WithMe.DAL;
using WithMe.ViewModels;

namespace WithMe.Controllers
{
    public class ThirdMenuController : Controller
    {
        private readonly AppDbContext _context;
        public ThirdMenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ThirdMenuVM thirdMenuVM = new ThirdMenuVM();
            thirdMenuVM.dessertssectionforthirdmenu = _context.DessertsSectionForThirdMenus.ToList();
            thirdMenuVM.drinkssectionforthirdmenu = _context.DrinksSectionForThirdMenus.ToList();
            return View(thirdMenuVM);
        }
    }
}
