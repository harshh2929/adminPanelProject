using adminPanelProject.Data;
using adminPanelProject.Models.Login;
using Microsoft.EntityFrameworkCore;

namespace adminPanelProject.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly DataContext _context;

        public LoginService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Login>> LoginUser(Login login)
        {
            try
            {
                // Create a local copy of the login variable
                var username = login.Username;
                var password = login.Password;

                // Check if the user exists in the SignUp table
                var userExists = await _context.Signup.AnyAsync(s => s.Username == username && s.Password == password);

                if (userExists)
                {
                    //returning all Login records in the database
                    _context.Login.Add(login);
                    await _context.SaveChangesAsync();

                    return await _context.Login.ToListAsync();
                    //return await _context.Login.ToListAsync();
                }
                else
                {
                    throw new Exception("User not found. Please sign up first.");
                }
            }
            catch (Exception)
            {
                return null; 
            }
        }
    }

}