using Microsoft.ApplicationInsights;
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

            var counter = Metrics.CreateCounter("PageLoad", "Navigation");
            counter.Inc();

            var telemetryClient = new TelemetryClient();
            telemetryClient.Context.User.Id = "mkonkolowicz";
            telemetryClient.Context.Device.Id = "57L8HR2";

            telemetryClient.GetMetric("FakeSocial").TrackValue(130692544);
            
            return View();
        }
    }
}
