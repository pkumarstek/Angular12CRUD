using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string DepartmentName { get; set; }
		public string DateOfJoining { get; set; }
		public string PhotoFileName { get; set; }
	}
}
