using StudentsAndCourses.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Models.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> Registrations { get; set; }
    }
}
