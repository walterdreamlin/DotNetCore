﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
       public ViewResult Index()
        {
            return View(
                "Result",
                new Result
                {
                    Controller=nameof(HomeController),
                    Action=nameof(Index)
                });
        }
    }
}
