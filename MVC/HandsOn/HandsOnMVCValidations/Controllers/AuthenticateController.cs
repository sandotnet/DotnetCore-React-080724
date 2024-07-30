using HandsOnMVCValidations.Models;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCValidations.Repositories;
namespace HandsOnMVCValidations.Controllers
{
    public class AuthenticateController : Controller
    {
        private readonly UserRepository userRepository;
        public AuthenticateController()
        {
            userRepository = new UserRepository();
        }
        public IActionResult Validate()
        {
            return View();
        }
        public IActionResult Details(User user)
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Validate(Login login)
        {
            if (ModelState.IsValid) //Validates Model
            {
                HandsOnMVCValidations.Models.User user = userRepository.Validate(login);
                if (user != null)
                    return RedirectToAction("Details", user);
                else
                {
                    ViewBag.Error = "Invalid User Credentials";
                    return View();
                }
            }
            else
                return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid) //validating user model
            {
                userRepository.Register(user);
                return RedirectToAction("Validate");
            }
            else
            {
                return View();
            }
           
        }
    }
}
