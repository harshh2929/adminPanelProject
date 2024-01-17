using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;
using adminPanelProject.Models.Seller;
using adminPanelProject.Services.EmployeeService;
using adminPanelProject.Services.SellerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace adminPanelProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployee()
        {

            return await _employeeService.GetAllEmployeeAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(EmployeePost employee)
        {
            try
            {
                var result = await _employeeService.AddEmployee(employee);
                return CreatedAtAction(nameof(AddEmployee), result);
            }
            catch (Exception )
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
