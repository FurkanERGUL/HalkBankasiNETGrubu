using APIProject.Entities;
using APIProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _empService;
        public EmployeeController(IEmployeeService empService)
        {
            _empService = empService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllEmployees() 
        {
            var employees = _empService.GetAllEmployees();
            if (employees is not null)
                return Ok(employees);
            else
                return BadRequest();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetEmployee(int id) 
        {
            var employee = await _empService.GetEmployeesById(id);
            if(employee!=null)
                return Ok(employee);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("[action]/{department}")]
        public IActionResult GetEmployeesByDepartment(string department)
        {
            var employees = _empService.GetEmployeesByDepartment(department);
            if(employees!=null)
                return Ok(employees);
            else
                return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            var createdEmp = _empService.CreateEmployee(employee);
            return CreatedAtAction("GetEmployee", new {id=employee.Id}, createdEmp);
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            return Ok(_empService.UpdateEmployee(employee));
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _empService.DeleteEmployee(id);
            return Ok("Personel silindi");
        }
    }
}
