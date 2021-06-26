using EmpWebAPI.Models;
using EmpWebAPI.Repo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Controllers
{
	[Route("api/employee")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		readonly IDataRepository<Employee> _employeeRepo;
		readonly IWebHostEnvironment _env;
		public EmployeeController(IDataRepository<Employee> employeeRepository, IWebHostEnvironment env)
		{
			_employeeRepo = employeeRepository;
			_env = env;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return new JsonResult(_employeeRepo.GetAll());
		}

		[HttpPost]
		public IActionResult Get(int Id)
		{
			return new JsonResult(_employeeRepo.Get(Id));
		}

		[Route("SaveFile")]
		[HttpPost]
		public JsonResult SaveFile()
		{
			try
			{
				var httpRequest = Request.Form;
				var postedFile = httpRequest.Files[0];
				string fileName = postedFile.Name;
				var physicalPath = _env.ContentRootPath + "/Photos/" + fileName;

				using(var stream = new FileStream(physicalPath,FileMode.Create))
				{
					postedFile.CopyTo(stream);
				}

				return new JsonResult(fileName);
			}
			catch(Exception ex)
			{
				return new JsonResult("anonymous.png");
			}
		}
	}
}
