using StudentsAndCourses.Library.Models.Entity;
using System.Collections.Generic;

namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface IRegistrationViewModel
    {
        public Course Course { get; set; }
        public List<Student> Students { get; set; }
    }
}
