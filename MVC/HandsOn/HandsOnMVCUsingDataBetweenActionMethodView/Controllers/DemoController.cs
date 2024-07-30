using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingDataBetweenActionMethodView.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string title = "welcome to mvc";
            //set value in viewData
            ViewData["title"]=title;
            string[] flowers = { "Rose", "Lilly", "Jasmine" };
            ViewData["flower"] = flowers;
            return View();
        }
        public IActionResult Details()
        {
            string title = "welcome to mvc";
            //set value in viewbag
            ViewBag.Title=title;
            string[] flowers = { "Rose", "Lilly", "Jasmine" };
            ViewBag.Flowers = flowers;
            return View();
        }
        public IActionResult View1()
        {
            double interest = 3.45;
            //set value in Tempdata
            TempData["k"]=interest.ToString();
            return RedirectToAction("View2"); //Redirect to View2 action method
        }
        public IActionResult View2()
        {
            return View();
        }
        public IActionResult Greet(string name)
        {
            ViewBag.Name=name;
            return View();
        }
        public IActionResult Show(int id,string name)
        {
            ViewBag.ID=id;
            ViewBag.Name=name;
            return View();
        }
    }
}
