using HandsOnAPIUsingEFCodeFirst.DTOS;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        //public OrderController()
        //{
        //    orderRepository = new OrderRepository();
        //}
        [HttpPost,Route("MakeOrder")]
        public IActionResult MakeOrder([FromBody]OrderDTO orderDto)
        {
            //assing orderDto to order entity
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                ProductId=orderDto.ProductId,
                UserId=orderDto.UserId,
                TotalPrice=orderDto.TotalPrice,
                OrderDate=DateTime.Now
            };

            orderRepository.MakeOrder(order);   
            return Ok(order);
        }
    }
}
