using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Collections.Generic;
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employees = new List<Employee>()
            { new Employee{Id=1, Name="Deepa",Department="Developer",Salary=45000},
              new Employee{Id=2, Name="Jasprit",Department="Manager",Salary=74000},
              new Employee{Id=3, Name="Sameer",Department="Developer",Salary=52000},
              new Employee{Id=4, Name="Pooja",Department="Tester",Salary=44000},
              new Employee{Id=5, Name="Hina",Department="Accounts",Salary=65000},
            };
            ViewData["emplist"] = employees;

            ViewBag.emplist = employees;
            return View();
        }
    }
}
