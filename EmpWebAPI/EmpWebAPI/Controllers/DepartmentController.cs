using EmpWebAPI.Models;
using EmpWebAPI.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Controllers
{
	[Route("api/department")]
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		private readonly IDataRepository<Department> _departmentRepo;
		public DepartmentController(IDataRepository<Department> departmentRepo)
		{
			_departmentRepo = departmentRepo;
		}

		[HttpGet]
		public JsonResult GetAll()
		{
			try
			{
				return new JsonResult(_departmentRepo.GetAll());
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		[HttpPost]
		public JsonResult  Get(int Id)
		{
			try
			{
				return new JsonResult(_departmentRepo.Get(Id));
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		//[HttpPost]
		//public JsonResult Add(Department department)
		//{
		//	try
		//	{
		//		return new JsonResult(_departmentRepo.Get(Id));
		//	}
		//	catch (Exception ex)
		//	{
		//		throw;
		//	}
		//}
	}
}
