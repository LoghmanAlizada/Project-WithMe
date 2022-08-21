using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Controllers
{
    public class ChefController : Controller
    {
        private readonly AppDbContext _context;
        public ChefController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ChefPage> chefPage = _context.ChefPages.ToList();

            return View(chefPage);
        }
    }
}
