using Microsoft.AspNetCore.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class DemoController : Controller
    {
        [Route("GetAll")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Users/Greet")]
        public IActionResult Greet()
        {
            return View();
        }
        public IActionResult Details() //access using convention routing
        {
            return View();
        }
    }
}
