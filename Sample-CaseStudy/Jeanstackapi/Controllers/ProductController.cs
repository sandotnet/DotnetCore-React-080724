using Jeanstackapi.Entities;
using Jeanstackapi.Repositiries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jeanstackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly  ProductInterface _ProductModel;

        public ProductController(ProductInterface productModel)
        {
            _ProductModel = productModel;
        }

       

       
        [HttpGet,Route("/products")]
        [Authorize(Roles = "admin,customer")]
        public IActionResult getAllProducts() {
            var products = _ProductModel.GetAllProducts();
            return Ok(products);
        }
        [HttpGet,Route("/products/{id}")]
        [Authorize(Roles = "admin,customer")]
        public IActionResult getProductBYId(int id)
        {
            var product = _ProductModel.GetProductById(id);
            return Ok(product);
        }
        [HttpDelete,Route("/products/{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult deleteProductById(int id) {
            _ProductModel.RemoveProductById(id);
            return Ok("deleted");
        }
        [HttpPatch,Route("/products/update")]
        [Authorize(Roles = "admin")]
        public IActionResult uppdateProduct(Product product)
        {
            _ProductModel.UpdateProductByID(product);
            var products = _ProductModel.GetAllProducts();
            return Ok(products);

        }
        [HttpPost,Route("/products")]
        [Authorize(Roles = "admin")]
        public IActionResult postProduct(Product product)
        {
            _ProductModel.AddProduct(product);
             var products= _ProductModel.GetAllProducts();
            return Ok(products);


        }
    }
}
