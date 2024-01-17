using adminPanelProject.Data;
using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;
using adminPanelProject.Models.Signup;
using Microsoft.EntityFrameworkCore;

namespace adminPanelProject.Services.SignupService
{
    public class SignupService : ISignupService
    {
        private readonly DataContext _context;
        public SignupService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Signup>> SignupUser(Signup signup)
        {
            //var Signupobject = new Signup
            //{
            //    Username = signup.Username,
            //    Email = signup.Email,
            //    Password = signup.Password,

            //};
            _context.Signup.Add(signup);
            await _context.SaveChangesAsync();
            return await _context.Signup.ToListAsync();
        }
    }
}
