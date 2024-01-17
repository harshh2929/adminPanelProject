using adminPanelProject.Models.Login;
using adminPanelProject.Models.Signup;

namespace adminPanelProject.Services.LoginService
{
    public interface ILoginService
    {
        Task<List<Login>> LoginUser(Login login);

    }
}
