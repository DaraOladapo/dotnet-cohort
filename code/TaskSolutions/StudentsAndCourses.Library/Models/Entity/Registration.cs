using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Models.Entity
{
    public class Registration
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
