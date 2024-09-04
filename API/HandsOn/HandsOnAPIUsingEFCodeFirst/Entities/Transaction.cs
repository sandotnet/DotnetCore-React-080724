namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? PaymentMode { get; set; }
        public int TransactionAmt { get; set; }
        public Guid OrderId { get; set; }
    }
}
