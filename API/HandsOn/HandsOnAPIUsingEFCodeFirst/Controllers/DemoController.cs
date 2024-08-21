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
        private readonly IProductAsyncRepository _productAsyncRepository;

        public DemoController(IProductAsyncRepository productAsyncRepository)
        {
            _productAsyncRepository = productAsyncRepository;
        }

        [HttpGet,Route ("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productAsyncRepository.GetAll());
        }

        [HttpGet,Route("GetById")]

        public  async Task<IActionResult> GetById(int id)
        {
            return Ok(await _productAsyncRepository.GetById(id));
        }

        // PUT Endpoint
        [HttpPut, Route("EditProduct")]
        public async Task<IActionResult> Edit([FromBody] Product product) // Edit product details
        {
            await _productAsyncRepository.Update(product);
            return StatusCode(200, product);
        }

        // DELETE Endpoint
        [HttpDelete, Route("DeleteProduct")]
        public async Task<IActionResult> Delete( int id) // Delete Product using id
        {
            await _productAsyncRepository.DeleteById(id);
            return Ok(); // Empty Response
        }

/*
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
        }*/
    }
}
