using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet,Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            return Ok("Get All Products");
        }
    }
}
