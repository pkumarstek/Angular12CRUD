using EmpWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.DBContext
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Department>().ToTable("Departments");

			modelBuilder.Entity<Employee>().HasData(
				new Employee
				{
					Id = 1,
					Name = "Prasanna",
					DepartmentName = "IT",
					DateOfJoining = "01/07/2015",
					PhotoFileName="sample.jpg"
				}
				);
		}
	}
}
