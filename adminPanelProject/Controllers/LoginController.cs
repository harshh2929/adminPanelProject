using adminPanelProject.Models.Login;
using adminPanelProject.Models.Signup;
using adminPanelProject.Services.LoginService;
using adminPanelProject.Services.SignupService;
using Microsoft.AspNetCore.Mvc;

namespace adminPanelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<ActionResult<List<Login>>> LoginUser(Login login)
        {
            try
            {
                var result = await _loginService.LoginUser(login);
                return CreatedAtAction(nameof(LoginUser), result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
