using Jeanstackapi.Entities;

namespace Jeanstackapi.Repositiries
{
    public interface OrderInterface
    {
        public void placeOrder(Order order);

        public List<Order> ViewOrderHistory();

    }
}
