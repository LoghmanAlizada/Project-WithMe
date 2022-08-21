using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WithMe.DAL;
using WithMe.Models;

namespace WithMe.Controllers
{
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;
        public GalleryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<GalleryPage> galleryPage = _context.GalleryPages.ToList();

            return View(galleryPage);
        }
    }
}
