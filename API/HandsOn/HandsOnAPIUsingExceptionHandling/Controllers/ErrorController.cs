using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingExceptionHandling.Controllers
{
   
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet,Route("error")]
        public IActionResult Error()
        {
            return Ok("Error Occured");
        }
    }
}
