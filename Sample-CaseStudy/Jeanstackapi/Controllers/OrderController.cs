using Jeanstackapi.Entities;
using Jeanstackapi.Repositiries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jeanstackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderInterface? orderInterface;

        public OrderController(OrderInterface orderInterface)
        {
            this.orderInterface = orderInterface;
        }

        [HttpGet,Route("/orders")]
        public IActionResult getOrders()
        {
            try
            {
                var orders = orderInterface.ViewOrderHistory();
                return Ok(orders);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost,Route("/orders")]
        
        public IActionResult postOrders(Order order)
        {
            try
            {
                orderInterface?.placeOrder(order);
                return Ok("added");
            }catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
