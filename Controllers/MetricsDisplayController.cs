using Microsoft.AspNetCore.Mvc;

namespace Metrics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsDisplayController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMetrics()
        {
            // This will be handled by OpenTelemetry middleware
            return Content("Metrics are exposed at /metrics endpoint.(eg:https://localhost:7218/metrics)", "text/plain");
        }
    }
}
