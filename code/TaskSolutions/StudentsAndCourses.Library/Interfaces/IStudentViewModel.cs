using StudentsAndCourses.Library.Models.Entity;
using System.Collections.Generic;

namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface IStudentViewModel
    {
        public Student Student { get; set; }
        public List<Course> Registrations { get; set; }
    }
}
