using Microsoft.AspNetCore.Mvc;

namespace HandsOnAttributeRouting.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Details/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();

        }
        [Route("Show/{name:double}")]
        public IActionResult Show(double name)
        {
            {
                return View();
            }
        }
    }
}
