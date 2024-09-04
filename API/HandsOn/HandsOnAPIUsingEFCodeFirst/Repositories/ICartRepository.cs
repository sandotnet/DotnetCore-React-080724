using HandsOnAPIUsingEFCodeFirst.DTOS;
using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface ICartRepository
    {
        void AddCart(Cart cart);
        List<CartDTO> GetCartItems(int userId);
    }
}
