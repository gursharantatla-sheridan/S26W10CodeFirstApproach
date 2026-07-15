using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace S26W10CodeFirstApproach
{
    // context class
    public class SchoolContext : DbContext
    {
        // connection string - REQUIRED
        // override the OnConfiguring method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = ConfigurationManager.ConnectionStrings["SchoolCF"].ConnectionString;
            optionsBuilder.UseSqlServer(connStr);
        }


        // entity sets - REQUIRED
        // define the DbSet<> properties
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }


        // data seeding - OPTIONAL
        // override the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard { StandardId = 3, StandardName = "Standard 3" },
                new Standard { StandardId = 4, StandardName = "Standard 4" },
                new Standard { StandardId = 5, StandardName = "Standard 5" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Ross", StandardId = 1 },
                new Student { StudentId = 2, StudentName = "Rachel", StandardId = 1 },
                new Student { StudentId = 3, StudentName = "Chandler", StandardId = 2 },
                new Student { StudentId = 4, StudentName = "Monica", StandardId = 2 },
                new Student { StudentId = 5, StudentName = "Joey", StandardId = 3 },
                new Student { StudentId = 6, StudentName = "Phoebe", StandardId = 4 }
            );
        }
    }
}
