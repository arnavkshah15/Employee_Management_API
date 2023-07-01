using FullStack.Application;
using FullStack.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FulStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly FStackService _service;

        public EmployeeController(FStackService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult <List<Employee>> Get()
        {
            var employeeFromService = _service.GetAllEmployees();
            return Ok(employeeFromService);
        }

        [HttpPost]
        public ActionResult<Employee> PostEmployee(Employee employee) {
            var Employee = _service.CreateEmployee(employee);
            return Ok(employee);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<Employee> GetEmployee([FromRoute]Guid id)
        {
            var employeeFromService=_service.GetEmployee(id);
            return Ok(employeeFromService);
        }
        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<Employee> UpdateEmployee([FromRoute] Guid id,Employee updateEmployeeRequest )
        {
            var employeeFromService = _service.UpdateEmployee(id,updateEmployeeRequest);
            return Ok(employeeFromService);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult DeleteEmployee([FromRoute] Guid id) {
        var employeeFromService=_service.DeleteEmployee(id);
            return Ok(employeeFromService);
        }

    }
}
