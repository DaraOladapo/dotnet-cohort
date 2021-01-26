using StudentsAndCourses.Library.Data;
using StudentsAndCourses.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        ApplicationDbContext _repoContext;
        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }
        IStudentRepository _students;

        ICourseRepository _courses;

        IRegistrationRepository _registrations;
        public IStudentRepository Students
        {
            get
            {
                if (_students == null)
                {
                    _students = new StudentRepository(_repoContext);
                }
                return _students;
            }
        }
        public ICourseRepository Courses
        {
            get
            {
                if (_courses == null)
                {
                    _courses = new CourseRepository(_repoContext);
                }
                return _courses;
            }
        }
        public IRegistrationRepository Registrations
        {
            get
            {
                if (_registrations == null)
                {
                    _registrations = new RegistrationRepository(_repoContext);
                }
                return _registrations;
            }
        }

        void IRepositoryWrapper.Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
