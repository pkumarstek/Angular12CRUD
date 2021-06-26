using EmpWebAPI.DBContext;
using EmpWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Repo
{
	public class EmployeeRepository : IDataRepository<Employee>
	{
		private readonly ApplicationDbContext _context;
		public EmployeeRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		
		public Employee Add(Employee employee)
		{
			_context.Employees.Add(employee);
			_context.SaveChanges();
			return employee;
		}

		public Employee Delete(int Id)
		{
			Employee employee = _context.Employees.Find(Id);
			if(employee != null)
			{
				_context.Employees.Remove(employee);
				_context.SaveChanges();
			}
			return employee;
		}

		public IEnumerable<Employee> GetAll()
		{
			return _context.Employees;
		}

		public Employee Get(int Id)
		{
			return _context.Employees.Find(Id);
		}

		public Employee Update(Employee employee)
		{
			var employeeChanges = _context.Employees.Attach(employee);
			employeeChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges();
			return employee;
		}
	}
}
