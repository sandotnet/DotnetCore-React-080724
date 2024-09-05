using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jeanstackapi.Entities
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This line tells EF to auto-generate the ID
        public int Id { get; set; } 
        public int productId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Image { get; set; }
        public decimal Rating { get; set; }
        public int qty { get; set; }
        public int userId { get; set; }  // Foreign key
         


    }
}
