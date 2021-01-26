using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DBFirstCS.Models
{
    public partial class StudentsAndCoursesDBContext : DbContext
    {
        public StudentsAndCoursesDBContext()
        {
        }

        public StudentsAndCoursesDBContext(DbContextOptions<StudentsAndCoursesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentsAndCoursesDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasIndex(e => e.CourseId, "IX_Registrations_CourseId");

                entity.HasIndex(e => e.StudentId, "IX_Registrations_StudentId");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.StudentId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
