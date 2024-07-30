using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Plese Enter UserName")]
        public string? Username { get; set; }
        [Required(ErrorMessage ="Please Enter Password")]
        public string? Password { get; set; }
    }
}
