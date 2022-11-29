using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Collections.Generic;
namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult StudentList()
        //{
        //    List<Student> students = new List<Student>()
        //    {
        //        new Student{Id=1,StudName="Naina",Total_Marks=457,Percentage=74.45},
        //        new Student{Id=2,StudName="Sid",Total_Marks=509,Percentage=77.48},
        //        new Student{Id=3,StudName="Priyanka",Total_Marks=536,Percentage=65.62},
        //        new Student{Id=4,StudName="Rohit",Total_Marks=547,Percentage=84.40},
        //        new Student{Id=5,StudName="Ajay",Total_Marks=465,Percentage=73.14},
        //    };

        //    ViewData["studlist"]=students;
        //    ViewBag.studlist = students;
        //    return View();
        //}
        public IActionResult StudentData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentData(Student student)
        {
            return View();
        }
    }
}
