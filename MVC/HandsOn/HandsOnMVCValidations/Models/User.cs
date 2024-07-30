using HandsOnMVCValidations.CustomValidators;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls Enter Name")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        [Range(18,34,ErrorMessage ="Age between 18 to 34")]
        public string? Age { get; set; }
        [Required(ErrorMessage = "Pls Enter Email")]
        [EmailAddress(ErrorMessage ="Invalid EmailId")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Pls Enter Mobile")]
        [RegularExpression("[6-9][0-9]{9}",ErrorMessage ="Invalid Mobile No")]
        public string? Mobile { get; set; }
       [CountryValidator()]
        public string? Country { get; set; }
        [Required(ErrorMessage = "Pls Enter Password")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Password allow only 6 to 8 chars")]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string? ConfirmPassword { get; set; }
    }
}
