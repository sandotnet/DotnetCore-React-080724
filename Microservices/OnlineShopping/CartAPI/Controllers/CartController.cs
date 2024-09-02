using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        [HttpGet,Route("GetCarts")]
        public IActionResult GetAll()
        {
            return Ok("Get All Cart Items");
        }
    }
}
