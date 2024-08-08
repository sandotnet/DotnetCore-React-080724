using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCClient.Models
{
    public class Product
    {
       
        public int ProductId { get; set; }
        public string? Name { get; set; } 
        public int Price { get; set; } 
        public int? Stock { get; set; } 
    }
}
