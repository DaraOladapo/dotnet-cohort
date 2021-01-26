using StudentsAndCourses.Library.Models.Entity;

namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface IAddRegistration
    {
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
