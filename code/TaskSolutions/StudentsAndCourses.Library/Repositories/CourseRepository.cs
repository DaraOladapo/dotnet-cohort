using StudentsAndCourses.Library.Data;
using StudentsAndCourses.Library.Interfaces;
using StudentsAndCourses.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
