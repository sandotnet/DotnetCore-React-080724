using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class Product
    {
        [Key] //set Id as a Primary Key
       // [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable identity
        public int ProductId { get; set; }
        [Column(TypeName ="varchar")] //set column type as varchar
        [StringLength(20)] //set size of the varchar
        public string? Name { get; set; } //set null constraint
        public int Price { get; set; } //set not null constraint
        public int? Stock { get; set; } //set null constraint
    }
}
