using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_task1.Controllers
{
    public class AhmadOdatController : Controller
    {
        // GET: AhmadOdat
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Name()
        {
            return Content("<h1>Ahmad Odat<h1/>");
        }

        public ActionResult Age()
        {
            return Content("<h2>my age is 27</h2>");
        }

        public ActionResult Major()
        {
            return Content("<h2>Electrical Engineer</h2>");
        }

        public ActionResult Hoppies()
        {
            return Content("<head><link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC\" crossorigin=\"anonymous\">\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM\" crossorigin=\"anonymous\"></script></head><table class='table table-stripped'><tr><th>hopy name</th><th>my age</th><tr/>" +
                "<tr><td>football</td><td>10 years</td><tr/>" +
                "<tr><td>swimming</td><td>from 15-25 yers</td><tr/><table/>");
        }
    }
}