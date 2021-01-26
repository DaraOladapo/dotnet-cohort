using StudentsAndCourses.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Interfaces
{
    public interface IRepositoryWrapper
    {
        IStudentRepository Students { get; }
        ICourseRepository Courses { get; }
        IRegistrationRepository Registrations { get; }
        void Save();
    }
}
