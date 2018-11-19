using Microsoft.AspNetCore.Mvc;

namespace ToriSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OurFamily()
        {
            ViewData["Message"] = "Maciek, Brandi and Victoria";

            return View();
        }
    }
}
