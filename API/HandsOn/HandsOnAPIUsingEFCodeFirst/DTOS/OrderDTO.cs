namespace HandsOnAPIUsingEFCodeFirst.DTOS
{
    public class OrderDTO
    {
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public int TotalPrice { get; set; }

    }
}
