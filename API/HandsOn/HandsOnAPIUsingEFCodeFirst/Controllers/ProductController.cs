using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public ProductController()
        //{
        //    _productRepository = new ProductRepository();
        //}
        //Get Endpoints
        [HttpGet,Route("GetProducts")]
        //[Authorize(Roles ="Admin")]
        public IActionResult GetAll() //Get All Product details
        {
            var products = _productRepository.GetAll();
            return StatusCode(200, products);
        }
        [HttpGet, Route("GetProduct/{id}")]
       // [Authorize(Roles ="Admin,User")]
        public IActionResult Get([FromRoute]int id) //Get a Product By Id
        {
            var product=_productRepository.GetProduct(id);
            return Ok(product);
            //if (product != null)
            //    return StatusCode(200, product);
            //else
            //    return StatusCode(404, "Invalid Id");
        }
        //Post Endpoint
        [HttpPost, Route("AddProduct")]
       // [Authorize(Roles ="Admin")]
        public IActionResult Add([FromBody]Product product) //add product details
        {
            _productRepository.Add(product);
            return StatusCode(200, product);
        }
        //Put Endpoint
        [HttpPut, Route("EditProduct")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Edit([FromBody]Product product) //Edit product details
        {
            _productRepository.Update(product);
            return StatusCode(200, product);
        }
        //Delete Endpoint
        [HttpDelete, Route("DeleteProduct")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Delete([FromQuery]int id) //Delete Product using id
        {
            _productRepository.Delete(id);
            return Ok(); //Empty Response
        }
    }
}
