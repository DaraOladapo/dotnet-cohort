using StudentsAndCourses.Library.Models.Entity;

namespace StudentsAndCourses.Library.Models.Interfaces
{
    public interface IRegistration
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
