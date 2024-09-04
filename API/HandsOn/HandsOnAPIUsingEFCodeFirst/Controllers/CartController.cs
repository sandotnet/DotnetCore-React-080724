using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        [HttpGet, Route("GetAllCartItems")]
        public IActionResult GetAll(int userId)
        {
            return Ok(cartRepository.GetCartItems(userId));
        }
        [HttpPost, Route("AddToCart")]
        public IActionResult Add(Cart cart)
        {
            cart.CartId = "C" + new Random().Next(1000, 9999);
            cartRepository.AddCart(cart);
            return Ok(cart);

        }
    }
}
