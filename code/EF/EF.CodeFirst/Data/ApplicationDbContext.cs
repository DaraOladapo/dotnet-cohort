using EF.CodeFirst.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public static string connectionString = "Data Source=.;Initial Catalog=CarsDB;Integrated Security=True";
        //construction chaining
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Car> Cars { get; set; }
    }
}
