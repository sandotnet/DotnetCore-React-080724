using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public string[] students = new string[] { "Rohan", "Chetan", "Monica" };
        [HttpGet,Route("GetAll")]
        //endpoint: /api/Student
        public IActionResult GetAllStudents()
        {
            //OK() retruns json data as a response with status code 200
            return Ok(students);
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            return Ok(students[id]);
        }
    }
}
