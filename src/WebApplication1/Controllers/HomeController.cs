using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PancakeModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var rec = new ButtermilkPancakeRecipe(12);
            ViewData["Title"] = "Buttermilk Pancakes!";
            ViewData["Message"] = "Choose The amount of pancakes and we will generate the correct recipe.";

            return View(rec);
        }

        public IActionResult Pancakes(decimal? NumberPancakes)
        {
            var rec = new ButtermilkPancakeRecipe(NumberPancakes??12);
            return View(rec);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public static string PrintAAA()
        {
            return "dog nuts";
          
        }
    }
}
