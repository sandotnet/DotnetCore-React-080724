using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jeanstackapi.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This line tells EF to auto-generate the ID
        public int Id { get; set; } // Change the data type to int for auto-incrementing

        // Other properties remain the same
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
    }
}
