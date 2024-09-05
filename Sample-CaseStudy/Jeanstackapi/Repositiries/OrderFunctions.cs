using Jeanstackapi.Entities;

namespace Jeanstackapi.Repositiries
{
    public class OrderFunctions : OrderInterface
    {
        private readonly MyContext _context;

        public OrderFunctions(MyContext context)
        {
            this._context = context;
        }

        public void placeOrder(Order order)
        {
            try
            {
                _context.orders.Add(order);
                _context.SaveChanges();


            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            throw new NotImplementedException(ex.Message);
            }
        }

        public List<Order> ViewOrderHistory()
        {
            try
            {
                var orders = _context.orders.ToList();
                return orders;
            }catch (Exception ex)
            {

            throw new NotImplementedException(ex.Message);
            }
        }
    }
}
