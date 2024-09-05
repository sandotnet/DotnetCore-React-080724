using System.ComponentModel.DataAnnotations;

namespace Jeanstackapi.Entities
{
    public class User
    {
        [Key]
       public int userId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string type { get; set; }
        
       

    }
}
