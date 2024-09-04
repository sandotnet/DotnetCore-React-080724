using HandsOnAPIUsingEFCodeFirst.DTOS;
using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ECommContext _context;

        public CartRepository(ECommContext context)
        {
            _context = context;
        }

        public void AddCart(Cart cart)
        {
           _context.Carts.Add(cart);
        _context.SaveChanges();
        }

        public List<CartDTO> GetCartItems(int userId)
        {
            var cartItesms = (from p in _context.Products
                              join
                              c in _context.Carts
                              on p.ProductId equals c.ProductId
                              select new CartDTO()
                              {
                                  ProductId=p.ProductId,
                                  Name=p.Name,
                                  Price=p.Price,
                                  Qty=1,
                                  CartId=c.CartId
                              }).ToList();
            return cartItesms;
        }
    }
}
