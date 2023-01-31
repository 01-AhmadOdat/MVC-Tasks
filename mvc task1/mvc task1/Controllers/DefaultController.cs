using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_task1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //public ActionResult Index()
        //{
        //    string x = "\"<img src=\\\".\\\\juce.png\\\" alt=\\\"\\\">\"";
         //return ("<a href='../juce.png' download ><img src = '../juce.png' /></a>");
        //    return View(x);
        //}http://localhost:53093/
        public string Index()
        {

            return ("<a href='../juce.png' download ><img src = '../juce.png' /></a>"+ "<br/><a href='../Views/Home/About.cshtml'><h1>About us<h1/></a>");
            //return ("<img src = '../juce.png' />");
        }

        public string About()
        {

            return ("<h1>About us<h1/><br/><h2>My name is Ahmad Odat<h2/><br/><img src = '../ahmad.png' />");
            
        }

        public string Contact()
        {

            return ("<a href='https://web.facebook.com/profile.php?id=100086789733640'><h1>Contact me<h1/></a>");

        }
    }
}