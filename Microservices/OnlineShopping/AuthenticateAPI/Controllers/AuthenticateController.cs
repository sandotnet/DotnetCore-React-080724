using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        //endpoints
        [HttpGet,Route("GetAllUsers")]
        public IActionResult GetUsers()
        {
            return Ok("Return All Users");
        }
        [HttpPost, Route("Register")]
        public IActionResult AddUser(object user)
        {
            return Ok("User Added");
        }
    }
}
