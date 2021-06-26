using EmpWebAPI.DBContext;
using EmpWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Repo
{
	public class DepartmentRepository : IDataRepository<Department>
	{
		private readonly ApplicationDbContext _context;
		public DepartmentRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public Department Add(Department department)
		{
			_context.Departments.Add(department);
			_context.SaveChanges();
			return department;
		}

		public Department Delete(int Id)
		{
			Department department = _context.Departments.Find(Id);
			if(department !=null)
			{
				_context.Departments.Remove(department);
				_context.SaveChanges();
			}
			return department;
		}

		public IEnumerable<Department> GetAll()
		{
			return _context.Departments;
		}

		public Department Get(int Id)
		{
			return _context.Departments.Find(Id);
		}

		public Department Update(Department department)
		{
			var deparmentChanges = _context.Departments.Attach(department);
			deparmentChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges();
			return department;
		}
	}
}
