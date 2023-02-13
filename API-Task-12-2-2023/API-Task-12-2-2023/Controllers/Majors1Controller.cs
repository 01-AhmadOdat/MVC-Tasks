using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using API_Task_12_2_2023.Models;

namespace API_Task_12_2_2023.Controllers
{
    public class Majors1Controller : Controller
    {
        private APITaskEntities db = new APITaskEntities();

        // GET: Majors1
        //public ActionResult Index()
        //{
        //    var majors = db.Majors.Include(m => m.Faculty);
        //    return View(majors.ToList());
        //}

        public ActionResult Index(int? id)
        {
            //var majoers = db.Majoers.Include(m => m.Facility);
            var majoers2 = db.Majors.Where(m => m.faculitiy_id == id);

            return View(majoers2.ToList());
        }

        // GET: Majors1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            return View(major);
        }

        // GET: Majors1/Create
        public ActionResult Create()
        {
            ViewBag.faculitiy_id = new SelectList(db.Faculties, "id", "name");
            return View();
        }

        // POST: Majors1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,faculitiy_id")] Major major)
        {
            if (ModelState.IsValid)
            {
                db.Majors.Add(major);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.faculitiy_id = new SelectList(db.Faculties, "id", "name", major.faculitiy_id);
            return View(major);
        }

        // GET: Majors1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            ViewBag.faculitiy_id = new SelectList(db.Faculties, "id", "name", major.faculitiy_id);
            return View(major);
        }

        // POST: Majors1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,faculitiy_id")] Major major)
        {
            if (ModelState.IsValid)
            {
                db.Entry(major).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.faculitiy_id = new SelectList(db.Faculties, "id", "name", major.faculitiy_id);
            return View(major);
        }

        // GET: Majors1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            return View(major);
        }

        // POST: Majors1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Major major = db.Majors.Find(id);
            db.Majors.Remove(major);
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
