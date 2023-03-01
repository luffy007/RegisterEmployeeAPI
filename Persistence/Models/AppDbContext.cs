using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 1,
                DepartmentName = "IT" 
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 2,
                DepartmentName = "HR"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 3,
                DepartmentName = "Payroll"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 4,
                DepartmentName = "Admin"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@gmail.com",
                DateOfBirth = new DateTime(1979,11,11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/mary.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "Marta",
                LastName = "Kruss",
                Email = "marta@gmail.com",
                DateOfBirth = new DateTime(1974, 10, 11),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/marta.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "Martina",
                LastName = "Schulz",
                Email = "martina@gmail.com",
                DateOfBirth = new DateTime(1985, 4, 11),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/martina.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 4,
                FirstName = "Mira",
                LastName = "Flix",
                Email = "mira@gmail.com",
                DateOfBirth = new DateTime(1989, 2, 5),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "images/mira.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 5,
                FirstName = "Leo",
                LastName = "Mark",
                Email = "leo@gmail.com",
                DateOfBirth = new DateTime(1989, 7, 5),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/leo.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 6,
                FirstName = "Riky",
                LastName = "Trup",
                Email = "riky@gmail.com",
                DateOfBirth = new DateTime(1991, 7, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/leo.png"
            });
        }
    }
}
