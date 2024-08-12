using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EComContext _context;
        public OrderRepository(EComContext context)
        {
            _context = context;
        }
        //public OrderRepository()
        //{
        //    _context = new ECommContext();
        //}
        public List<Order> GetAllOrders(int userId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public void MakeOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges(); 
        }
    }
}
