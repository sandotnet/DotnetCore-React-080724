using MessageService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageRepository messageRepository;
        public MessageController()
        {
            messageRepository = new MessageRepository();
        }
        [HttpGet,Route("Greet/{name}")]
        public IActionResult Greet(string name)
        {
            var result= messageRepository.Greet(name);
            return Ok(result);
        }
    }
}
