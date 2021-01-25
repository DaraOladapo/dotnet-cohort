using Microsoft.EntityFrameworkCore;
using StudentsAndScores.Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndScores.Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
