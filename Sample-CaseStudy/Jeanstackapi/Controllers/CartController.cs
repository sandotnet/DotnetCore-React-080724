using Jeanstackapi.Entities;
using Jeanstackapi.models;
using Jeanstackapi.Repositiries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jeanstackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartInterface cart_context;

        public CartController(CartInterface cart_context)
        {
            this.cart_context = cart_context;
        }
        [HttpGet,Route("/carts")]
        [Authorize(Roles="customer,admin")]
        public IActionResult getAllCarts()
        {
            try
            {
                var carts=cart_context.getAllCarts();
                return Ok(carts);

            }catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPost,Route("/addToCart")]
        [Authorize(Roles ="customer,admin")]
        public IActionResult addToCart(Cart cart)
        {
            try
            {
                var data=cart_context.addTocart(cart);
                return Ok(data);

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpDelete,Route("/removeFromCart")]
        [Authorize(Roles ="admin,customer")]
        public IActionResult removeFromCart(int id)
        {
            try
            {
                cart_context.removeFromCart(id);
                return Ok("removed");

            }catch(Exception ex)
            {
                throw new Exception();
            }

        }
    }
}
