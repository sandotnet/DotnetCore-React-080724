using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Gender")]
        public string Gender { get; set; }
        [Range(18,90,ErrorMessage ="Age between 18 to 90")]
        public int Age { get; set; }
      
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage ="Invalid EmailId")] //validate input value with email fromat
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Mobile")]
        [RegularExpression("[6-9]\\d{9}", ErrorMessage = "Invalid Mobile No")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [RegularExpression("[a-zA-Z0-9]{6,8}",ErrorMessage ="Password shoud be 6 to 8 chars long")]
        public string Password { get; set; }
    }
}
