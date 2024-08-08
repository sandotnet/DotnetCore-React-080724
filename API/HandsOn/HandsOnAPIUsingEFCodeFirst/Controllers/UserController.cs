using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Models;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public UserController()
        //{
        //    _userRepository = new UserRepository();
        //}
        [HttpPost, Route("Register")]
        public IActionResult AddUser(User user)
        {
            _userRepository.Register(user);
            return Ok(user);
        }
        [HttpPost, Route("Validate")]
        public IActionResult ValidUser(Login login)
        {
            {
                var user = _userRepository.ValidUser(login.Email,login.Password);
                //if (user != null)
                //{
                //    return Ok(user);
                //}
                //else
                //    return NotFound("Invalid UserDetails!!!");
                return Ok(user);


            }
        }
    }
}