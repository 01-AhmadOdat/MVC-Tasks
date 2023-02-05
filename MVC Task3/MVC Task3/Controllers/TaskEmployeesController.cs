using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MVC_Task3.Models;

namespace MVC_Task3.Controllers
{
    public class TaskEmployeesController : Controller
    {
        private OdatEntities1 db = new OdatEntities1();

        // GET: TaskEmployees
        public ActionResult Index()
        {
            return View(db.TaskEmployees.ToList());
        }
        [HttpPost]
        public ActionResult Index(string sname , string drone)
        {
            var employees = db.TaskEmployees.ToList();

            if (drone == "first") { employees = db.TaskEmployees.Where(a => a.First_Name.Contains(sname)).ToList(); }
            else if(drone == "last") { employees = db.TaskEmployees.Where(a => a.Last_Name.Contains(sname)).ToList(); }
            else if (drone == "email") { employees = db.TaskEmployees.Where(a => a.Email.Contains(sname)).ToList(); }
            else if (drone == "phone") { employees = db.TaskEmployees.Where(a => a.Phone.Contains(sname)).ToList(); }
            else if (drone == "age") { employees = db.TaskEmployees.Where(a => a.Age.ToString().Contains(sname)).ToList(); }
            else if (drone == "job") { employees = db.TaskEmployees.Where(a => a.Job_Title.ToString().Contains(sname)).ToList(); }
            //var employees = db.TaskEmployees.Where(a => a.First_Name.Contains(sname)||a.Last_Name.Contains(sname));

            return View(employees.ToList());
        }

        // GET: TaskEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskEmployee taskEmployee = db.TaskEmployees.Find(id);
            if (taskEmployee == null)
            {
                return HttpNotFound();
            }
            return View(taskEmployee);
        }

        // GET: TaskEmployees/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: TaskEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,Email,Phone,Age,Job_Title,Gender")] TaskEmployee taskEmployee,HttpPostedFileBase file,HttpPostedFileBase filename)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string shraideh = Path.GetFileName(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/Images"), shraideh);
                    file.SaveAs(path);
                    taskEmployee.Image = shraideh;

                }
                if (filename.ContentLength > 0)
                {
                    string shraideh = Path.GetFileName(filename.FileName);
                    string path = Path.Combine(Server.MapPath("~/CVs"), shraideh);
                    filename.SaveAs(path);
                    taskEmployee.CV = shraideh;

                }
                db.TaskEmployees.Add(taskEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskEmployee);
        }

        // GET: TaskEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskEmployee taskEmployee = db.TaskEmployees.Find(id);
            if (taskEmployee == null)
            {
                return HttpNotFound();
            }
            return View(taskEmployee);
        }

        // POST: TaskEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_Name,Email,Phone,Age,Job_Title,Gender")] TaskEmployee taskEmployee, HttpPostedFileBase file, HttpPostedFileBase filename)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string shraideh = Path.GetFileName(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/Images"), shraideh);
                    file.SaveAs(path);
                    taskEmployee.Image = shraideh;

                }
                if (filename.ContentLength > 0)
                {
                    string shraideh = Path.GetFileName(filename.FileName);
                    string path = Path.Combine(Server.MapPath("~/CVs"), shraideh);
                    filename.SaveAs(path);
                    taskEmployee.CV = shraideh;

                }
                db.Entry(taskEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskEmployee);
        }

        // GET: TaskEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskEmployee taskEmployee = db.TaskEmployees.Find(id);
            if (taskEmployee == null)
            {
                return HttpNotFound();
            }
            return View(taskEmployee);
        }

        // POST: TaskEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskEmployee taskEmployee = db.TaskEmployees.Find(id);
            db.TaskEmployees.Remove(taskEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
