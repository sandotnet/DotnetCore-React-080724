using System.ComponentModel.DataAnnotations;

namespace Jeanstackapi.models
{
    public class CartModel
    {
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
        public int userId { get; set; }
    }
}
