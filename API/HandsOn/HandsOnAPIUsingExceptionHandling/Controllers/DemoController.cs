using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("Throw")]
        public IActionResult Throw() =>
    throw new Exception("Sample exception.");
    }
}

