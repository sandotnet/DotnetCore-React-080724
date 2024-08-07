using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        //Get Endpoints
        [HttpGet,Route("GetProducts")]
        public IActionResult GetAll() //Get All Product details
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }
        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult Get([FromRoute]int id) //Get a Product By Id
        {
            var product=_productRepository.GetProduct(id);
            if (product != null)
                return StatusCode(200, product);
            else
                return StatusCode(404, "Invalid Id");
        }
        //Post Endpoint
        [HttpPost, Route("AddProduct")]
        public IActionResult Add([FromBody]Product product) //add product details
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }
        //Put Endpoint
        [HttpPut, Route("EditProduct")]
        public IActionResult Edit([FromBody]Product product) //Edit product details
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }
        //Delete Endpoint
        [HttpDelete, Route("DeleteProduct")]
        public IActionResult Delete([FromQuery]int id) //Delete Product using id
        {
            _productRepository.Delete(id);
            return Ok(); //Empty Response
        }
    }
}
