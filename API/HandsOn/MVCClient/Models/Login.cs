using System.ComponentModel.DataAnnotations;
namespace MVCClient.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Enter Username")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}
