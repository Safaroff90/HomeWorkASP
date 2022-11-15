using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeworkASP.Controllors
{
    public class StudentController:Controller
    {

        public IActionResult Index()
        {
            List<string> students = new List<string>
           {
               "Seymur",
               "Eli",
               "Tahir"
           };
            ViewBag.Students = students;
            return View();
        }

        public ViewResult Detail(int id, string name)
        {
            ViewData["id"] = id;
            ViewBag.Id = 55;
            TempData["id"] = id;

            ViewBag.name = name;

            return View();  
        }
    }
}
