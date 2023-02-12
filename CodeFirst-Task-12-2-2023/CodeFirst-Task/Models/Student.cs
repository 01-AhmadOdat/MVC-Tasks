using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_Task.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public int Age { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

    }
}