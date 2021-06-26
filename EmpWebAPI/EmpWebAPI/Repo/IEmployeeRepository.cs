using EmpWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Repo
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetAllEmployees();
		Employee GetEmployee(int Id);
		Employee AddEmployee(Employee employee);

		Employee UpdateEmployee(Employee employee);

		Employee DeleteEmployee(int Id);
	}
}
