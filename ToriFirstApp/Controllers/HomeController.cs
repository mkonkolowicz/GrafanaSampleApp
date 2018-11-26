using Microsoft.AspNetCore.Mvc;
using Prometheus;

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

            var counter = Metrics.CreateCounter("Page Load", "Navigation");
            counter.Inc();

            return View();
        }
    }
}
