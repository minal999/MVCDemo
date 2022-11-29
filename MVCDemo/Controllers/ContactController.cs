using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Contact = form["contact_no"];
            ViewBag.Message = form["message"];

            return View("Queries");
        }
    }
}
