using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Prometheus;
using System.Collections.Generic;

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

            var counter = Metrics.CreateCounter("PageLoad", "Navigation");
            counter.Inc();

            var telemetryClient = new TelemetryClient();
            telemetryClient.Context.User.Id = "mkonkolowicz";
            telemetryClient.Context.Device.Id = "9FCLVT2";

            var social = new Dictionary<string, string>() { { "ssn", "123-45-6789" } };
            telemetryClient.TrackEvent("Social", social);
            
            return View();
        }
    }
}
