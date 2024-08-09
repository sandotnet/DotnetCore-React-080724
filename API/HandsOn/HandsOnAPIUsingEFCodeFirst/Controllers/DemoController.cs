using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IProuctAsyncRepository repository;

        public DemoController(IProuctAsyncRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet,Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return  Ok(await repository.GetAll());
        }
        [HttpGet,Route("GetById/{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
           return Ok(await repository.GetById(id));
        }
    }
}
