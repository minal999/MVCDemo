using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Phone",Company="Samsung",Price=52000},
                new Product{Id=2,Name="Laptop",Company="Dell",Price=75000},
                new Product{Id=3,Name="Phone",Company="RealMe",Price=45000},
                new Product{Id=4,Name="TV",Company="LG",Price=52000},
                new Product{Id=5,Name="Laptop",Company="Lenovo",Price=69000}
            };
            ViewBag.Products = products;
            return View();
        }
    }
}
