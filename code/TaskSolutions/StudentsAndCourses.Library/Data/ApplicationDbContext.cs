using Microsoft.EntityFrameworkCore;
using StudentsAndCourses.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndCourses.Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
