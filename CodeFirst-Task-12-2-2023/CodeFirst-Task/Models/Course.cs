using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_Task.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string price { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }




    }
}