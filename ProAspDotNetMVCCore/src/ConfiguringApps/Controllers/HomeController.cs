using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infranstructure;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        private ILogger<HomeController> logger;

        public HomeController(UptimeService up,ILogger<HomeController> log)
        {
            uptime = up;
            logger = log;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            logger.LogDebug($"Hanled {Request.Path} at uptime {uptime.Uptime}");

            return View(new Dictionary<string, string> { ["Message"]="This is the Index action",
            ["Uptime"]=$"{uptime.Uptime}ms"});
        }
    }
}
