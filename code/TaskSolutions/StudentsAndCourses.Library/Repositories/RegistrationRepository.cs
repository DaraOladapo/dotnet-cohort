using StudentsAndCourses.Library.Data;
using StudentsAndCourses.Library.Interfaces;
using StudentsAndCourses.Library.Models.Entity;

namespace StudentsAndCourses.Library.Repositories
{
    public class RegistrationRepository : Repository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
