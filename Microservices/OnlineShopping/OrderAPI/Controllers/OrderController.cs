using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet,Route("GetAllOrders")]
        public IActionResult GetAllOrders()
        {
            return Ok("All the Orders");
        }
    }
}
