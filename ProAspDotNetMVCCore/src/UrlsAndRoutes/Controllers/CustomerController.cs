using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Result",
                new Result {
                    Controller=nameof(CustomerController),
                    Action=nameof(Index)
                });
        }

        public IActionResult List() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List)
            });
    }
}
