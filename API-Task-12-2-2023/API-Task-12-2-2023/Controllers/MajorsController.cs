using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API_Task_12_2_2023.Models;

namespace API_Task_12_2_2023.Controllers
{
    public class MajorsController : ApiController
    {
        private APITaskEntities db = new APITaskEntities();

        // GET: api/Majors
        public IQueryable<Major> GetMajors()
        {
            return db.Majors;
        }


        // GET: api/Majors/5
        [ResponseType(typeof(Major))]
        public IHttpActionResult GetMajor(int id)
        {
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return NotFound();
            }

            return Ok(major);
        }

        // PUT: api/Majors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMajor(int id, Major major)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != major.id)
            {
                return BadRequest();
            }

            db.Entry(major).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MajorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Majors
        [ResponseType(typeof(Major))]
        public IHttpActionResult PostMajor(Major major)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Majors.Add(major);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = major.id }, major);
        }

        // DELETE: api/Majors/5
        [ResponseType(typeof(Major))]
        public IHttpActionResult DeleteMajor(int id)
        {
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return NotFound();
            }

            db.Majors.Remove(major);
            db.SaveChanges();

            return Ok(major);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MajorExists(int id)
        {
            return db.Majors.Count(e => e.id == id) > 0;
        }
    }
}