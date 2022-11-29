using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> list = new List<string>();
            list.Add("Select option");
            list.Add("Yes");
            list.Add("No");

            ViewData["option"] = new SelectList(list);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> Hobbies)
        {
            ViewBag.Name = form["name"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = Hobbies;
            ViewBag.Option = form["option"];
            return View("Details");
        }
    }
}
