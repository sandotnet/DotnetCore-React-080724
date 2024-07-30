using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCAPP.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
