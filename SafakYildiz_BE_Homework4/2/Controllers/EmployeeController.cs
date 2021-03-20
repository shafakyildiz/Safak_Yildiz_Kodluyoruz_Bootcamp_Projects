using Microsoft.AspNetCore.Mvc;
using RequestResponseLoggingDemo.Web.Models;
using System;

namespace RequestResponseLoggingDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Employee> GetByID(int id)
        {
            var employee = new Employee()
            {
                ID = id,
           
                DateOfBirth = DateTime.Now
            };

            return Ok("You requested the response at: " + DateTime.Now.AddSeconds(-5) + "\n\nYou obtained this response at: " + employee.DateOfBirth);
        }
    }
}