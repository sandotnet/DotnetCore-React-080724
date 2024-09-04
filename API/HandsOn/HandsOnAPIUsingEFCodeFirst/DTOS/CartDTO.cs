namespace HandsOnAPIUsingEFCodeFirst.DTOS
{
    public class CartDTO
    {
       public string CartId { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; } //set null constraint
        public int Price { get; set; } //set not null constraint
        public int Qty { get; set; } = 1;
    }
}
