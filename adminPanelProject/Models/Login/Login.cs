using System.ComponentModel.DataAnnotations;

namespace adminPanelProject.Models.Login
{
   public class Login
    {
        [Key]
        public string  Username { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
