using Authentication8_2_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentication8_2_2023.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        project5Entities db = new project5Entities();
        public ActionResult Index()
        {
            var Amd = db.Products.ToList();
            return View(Amd);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}