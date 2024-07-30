using Microsoft.AspNetCore.Mvc;
using HandsOnModels.Models;
namespace HandsOnModels.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductRepository();
        }
        public IActionResult Index()
        {
            var products = productRepository.GetProducts();
            return View(products);
        }
        //public IActionResult Details()
        //{
        //    //initiate product
        //    var product = new Product() { Id = 1, Name = "Mouse", Description = "Computer parts", Price = 500 };
        //    return View(product);
        //}
        public IActionResult Details(int id)
        {
            //initiate product
            //var product = products.SingleOrDefault(p=>p.Id==id);
            var product=productRepository.GetProduct(id);   
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product) 
            {
            productRepository.Add(product);
            return RedirectToAction("Index");
            }
    }
}
