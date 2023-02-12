using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_Task.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int NameId { get; set; }
        public int CourseId { get; set; }
        public string Discription { get; set; }

        [ForeignKey("NameId")]
        public virtual Student Student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course CourseCourse { get; set; }
    }
}