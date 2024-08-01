using Microsoft.AspNetCore.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    //[Route("SMS/Student")]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetAll")]
        public IActionResult Show()
        {
            return View();
        }
        [Route("Details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
