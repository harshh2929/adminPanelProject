using System.ComponentModel.DataAnnotations;

namespace adminPanelProject.Models.Signup
{
    public class Signup
    {
        [Key]
        public string Username { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
