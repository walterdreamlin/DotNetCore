﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infranstructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;

        public HomeController(UptimeService up)
        {
            uptime = up;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new Dictionary<string, string> { ["Message"]="This is the Index action",
            ["Uptime"]=$"{uptime.Uptime}ms"});
        }
    }
}
