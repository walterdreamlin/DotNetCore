using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name??"<No Name>";
                decimal? price = p?.Price??0;
                string relateName = p?.Related?.Name??"<None>";
                results.Add(string.Format("Name:{0},Price:{1},Related:{2}", name, price,relateName));
            }

            //return View(new string[] { "C#", "Language", "Features" });
            return View(results);
        }
    }
}
