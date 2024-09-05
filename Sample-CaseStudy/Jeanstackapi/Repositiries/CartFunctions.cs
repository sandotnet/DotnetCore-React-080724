using Jeanstackapi.Entities;
using Jeanstackapi.models;
using Microsoft.EntityFrameworkCore;

namespace Jeanstackapi.Repositiries
{
    public class CartFunctions : CartInterface
    {
        private readonly MyContext context;
        public CartFunctions(MyContext context)
        {
            this.context = context;
        }
        public Cart addTocart(Cart cart)
        {
            try
            {

                var existingCartItem = context.carts.FirstOrDefault(c => c.Id == cart.Id && c.userId == cart.userId);
                Console.WriteLine(existingCartItem);
                if (existingCartItem != null)
                {

                    existingCartItem.qty += 1;
                    context.SaveChanges();
                    return existingCartItem;
                }
                else
                {
                    cart.qty = 1;
                    
                    context.carts.Add(cart);
                    context.SaveChanges();
                    return context.carts.FirstOrDefault(c => c.Id == cart.Id && c.userId == cart.userId);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public List<Cart> getAllCarts() {
            try
            {
                var carts = context.carts.ToList();
                return carts;
            }catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
        public void removeFromCart(int cartId)
        {
           
                try
                {
                    var cart = context.carts.FirstOrDefault(c => c.Id == cartId && c.userId == c.userId);

                    if (cart != null)
                    {
                        if (cart.qty > 1)
                        {
                           
                            cart.qty--;
                        }
                        else
                        {
                            // If quantity is 1 or less, remove the item from the cart
                            context.carts.Remove(cart);
                        }

                        context.SaveChanges();
                    }
                    else
                    {
                        
                        throw new InvalidOperationException("Cart item not found.");
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception appropriately
                    throw new Exception("Error occurred while removing item from cart.", ex);
                
            }

        }
    }
}
