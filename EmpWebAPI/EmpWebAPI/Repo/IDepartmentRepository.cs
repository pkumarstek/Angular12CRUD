using EmpWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Repo
{
	interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
		Department GetDepartment(int Id);
		Department AddDepartment(Department department);
		Department UpdateDepartment(Department department);
		Department DeleteDepartment(int Id);
	}
}
