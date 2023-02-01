using MVC_task2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_task2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Models.Student>stu= new List<Models.Student>();
            stu.Add(new Student {ID=1, Name= "Ahmad Odat", Major="Electrical engineering",Faculty="Engineering" });
            stu.Add(new Student { ID = 2, Name = "Hassan", Major = "computer sience", Faculty = "IT" });

            return View(stu);
        }

    }
}