using Microsoft.AspNetCore.Mvc;
using MVCClient.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() //Get All Products
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5005/api/Product/"); //set endpoint
                //set the content type(return response data in json form)
                MediaTypeWithQualityHeaderValue contentType =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                //invoking endpoint(retrun response in json)
                HttpResponseMessage response = client.GetAsync("GetProducts").Result;
                //de serialize json data into specific model
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>
                    (response.Content.ReadAsStringAsync().Result);
                return View(products);
            }
         
        }
        public IActionResult Details(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5005/api/Product/"); //set endpoint
                //set the content type(return response data in json form)
                MediaTypeWithQualityHeaderValue contentType =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                //invoking endpoint(retrun response in json)
                HttpResponseMessage response = client.GetAsync("GetProduct/"+id).Result;
                //de serialize json data into specific model
                Product product = JsonConvert.DeserializeObject<Product>
                    (response.Content.ReadAsStringAsync().Result);
                return View(product);
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5005/api/Product/"); //set endpoint
                //convert model data to json
                var contentData = new StringContent(JsonConvert.SerializeObject(product),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("AddProduct",contentData).Result;
                return RedirectToAction("Index");
            }
        }
    }
}
