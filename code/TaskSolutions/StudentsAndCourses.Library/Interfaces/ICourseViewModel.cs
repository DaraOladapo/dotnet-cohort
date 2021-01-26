using StudentsAndCourses.Library.Models.Entity;
using System.Collections.Generic;

namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface ICourseViewModel
    {
        public ICourse Course { get; set; }
        public IList<IStudent> Students { get; set; }
    }
}
