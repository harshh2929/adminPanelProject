using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;
using adminPanelProject.Models.Signup;
using adminPanelProject.Services.EmployeeService;
using adminPanelProject.Services.SignupService;
using Microsoft.AspNetCore.Mvc;

namespace adminPanelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class SignupController : Controller
    {
        private readonly ISignupService _signupService;
        public SignupController(ISignupService signupService)
        {
            _signupService = signupService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Signup>>> SignupUser(Signup signup)
        {
            try
            {
                var result = await _signupService.SignupUser(signup);
                return CreatedAtAction(nameof(SignupUser), result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
