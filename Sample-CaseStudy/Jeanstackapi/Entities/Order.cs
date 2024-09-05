using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Jeanstackapi.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

         // Changed from 'carts' to 'Carts' for PascalCase

        [Required]
        public int UserId { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
