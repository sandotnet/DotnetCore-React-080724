using Jeanstackapi.Entities;
using Jeanstackapi.models;

namespace Jeanstackapi.Repositiries
{
    public interface CartInterface
    {
        public List<Cart> getAllCarts();
        public Cart addTocart(Cart cart);
        public void removeFromCart(int cartId);
       
    }
}
