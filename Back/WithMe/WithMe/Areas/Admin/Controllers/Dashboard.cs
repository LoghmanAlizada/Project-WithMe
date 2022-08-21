using Microsoft.AspNetCore.Mvc;

namespace WithMe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
