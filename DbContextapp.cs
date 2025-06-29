using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.database;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class DbContextapp : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)=>
            options.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeSurvey>()
                .Property(b => b.Gender)
                .HasConversion<string>();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSurvey> EmployeeSurveys { get; set; }
    }
}
