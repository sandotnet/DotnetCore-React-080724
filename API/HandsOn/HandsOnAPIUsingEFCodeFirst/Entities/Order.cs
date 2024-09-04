using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; } //set as ForeignKey
        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public int UserId { get; set; } //set as ForeignKey
        //Navigation Property
        public Product Product { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
