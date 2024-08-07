using HandsOnAPIUsingEFCodeFirst.DTOS;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;
        public OrderController()
        {
            orderRepository = new OrderRepository();
        }
        [HttpPost,Route("MakeOrder")]
        public IActionResult MakeOrder(OrderDTO orderDto)
        {
            //assing orderDto to order entity
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                ProductId=orderDto.ProductId,
                UserId=orderDto.UserId
            };

            orderRepository.MakeOrder(order);   
            return Ok(order);
        }
    }
}
