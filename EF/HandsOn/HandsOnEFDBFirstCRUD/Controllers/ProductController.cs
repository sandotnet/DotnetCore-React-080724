using HandsOnEFDBFirstCRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDBFirstCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDb1Context myDb1Context;
        public ProductController()
        {
            myDb1Context = new MyDb1Context(); //initiated myDb1Context boject
        }
        [HttpGet]
        public IActionResult Index() //Get All Products
        {
            var products = myDb1Context.Products;
            return View(products);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product=myDb1Context.Products.Single(p=>p.Pid==id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                myDb1Context.Products.Add(product); //adds record into product table
                myDb1Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = myDb1Context.Products.Single(p => p.Pid == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                myDb1Context.Products.Update(product);
                myDb1Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = myDb1Context.Products.Single(p => p.Pid == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            
                myDb1Context.Products.Remove(product);
                myDb1Context.SaveChanges();
                return RedirectToAction("Index");
           
        }
    }
}
