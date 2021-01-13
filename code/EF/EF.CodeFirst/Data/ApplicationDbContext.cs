using EF.CodeFirst.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        //construction chaining
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
    }
}
