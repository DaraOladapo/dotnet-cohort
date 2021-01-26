using StudentsAndCourses.Library.Data;
using StudentsAndCourses.Library.Interfaces;
using StudentsAndCourses.Library.Models.Entity;

namespace StudentsAndCourses.Library.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
