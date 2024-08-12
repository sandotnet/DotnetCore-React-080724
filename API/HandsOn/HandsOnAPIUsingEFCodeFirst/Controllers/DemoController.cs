using HandsOnAPIUsingEFCodeFirst.Entities;
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
        [HttpPost,Route("AddProduct")]
        public async Task<IActionResult> Add(Product product)
        {
            await repository.Add(product);
            return Ok(product);
        }
        [HttpPut, Route("EditProduct")]
        public async Task<IActionResult> Edit(Product product)
        {
            await repository.Update(product);
            return Ok(product);
        }
        [HttpDelete,Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await repository.DeleteById(id);
            return Ok();
        }
    }
}
