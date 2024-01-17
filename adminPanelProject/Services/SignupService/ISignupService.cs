using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;
using adminPanelProject.Models.Signup;

namespace adminPanelProject.Services.SignupService
{
    public interface ISignupService
    {
        Task<List<Signup>> SignupUser(Signup signup);
    }
}
