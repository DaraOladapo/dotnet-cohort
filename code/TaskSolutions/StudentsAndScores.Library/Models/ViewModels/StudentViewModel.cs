using StudentsAndScores.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndScores.Library.Models.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> Registrations { get; set; }
    }
}
