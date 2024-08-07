using HandsOnAPIUsingModelValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        List<Login> logins = new List<Login>()
        {
            new Login(){Username="Anna",Password="12345"},
            new Login(){Username="Merry",Password="12345"},
            new Login(){Username="Manoj",Password="12345"},
            new Login(){Username="Chandra",Password="12345"},
        };
        List<User> users = new List<User>()
        {
            new User(){Id=303,Name="Manoj",Email="manoj@gmail.com",Mobile="9890989090",Username="Manoj",Password="12345"}
        };
        [HttpPost,Route("Validate")]
        public IActionResult Validate(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var user = logins.SingleOrDefault(u => u.Username == login.Username && u.Password == login.Password);
                    //var user = (from u in logins
                    //            where u.Username == login.Username && 
                    //            u.Password == login.Password
                    //            select u).SingleOrDefault();
                    var user = (from l in logins
                                join u in users
                                on l.Username equals u.Username
                                where u.Username == login.Username &&
                                u.Password == login.Password
                                select u).SingleOrDefault();
                    if (user != null)
                    {
                        return StatusCode(200, user);
                    }
                    else
                    {
                        return StatusCode(200, new JsonResult("Invalid User Credentials"));
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPost,Route("Register")]
        public IActionResult Register([FromBody]User user) //[FormBody] exprected model data from the request body
        {
            try
            {
                if(ModelState.IsValid)
                {
                    user.Id = new Random().Next(1000, 9999);
                    //add model datais to backend table
                    users.Add(user);
                    return Ok(user); //Ok Retruns model data with status code 200
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
