using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["name"] = "Raj Sanjay Verma";
            ViewData["email"]="raj@gmail.com";
            ViewData["gender"] = "Male";

            List<string> Cricketers = new List<string>()
            {
               "Sachin Tendulkar", "Rohit Sharma","Virat Kolhi","M S Dhoni"
            };
            ViewData["Cricketers"] = Cricketers;

            ViewBag.name ="Raj Sanjay Verma";
            ViewBag.email = "raj@gmail.com";
            ViewBag.gender = "Male";
            ViewBag.Cricketers= Cricketers;
            return View();
        }


        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}