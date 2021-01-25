using StudentsAndCourses.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Models.ViewModels
{
    public class RegistrationViewModel
    {
        public Course Course { get; set; }
        public List<Student> Students { get; set; }
    }
}
