using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repositories;
using static System.Collections.Specialized.BitVector32;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        //Endpoints
        [HttpGet,Route("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {
                return Ok(studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetStudent/{id}")]
        public IActionResult GetStudentsByStd(int id)
        {
            try
            {
                return Ok(studentRepository.GetStudent(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetStudentsByStd/{std}")]
        public IActionResult GetStudentsByStd(string std)
        {
            try
            {
                return Ok(studentRepository.GetAllStudents(std));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetStudentsByStdAndSection/{std}/{section}")]
        public IActionResult GetStudentsByStd(string std,string section)
        {
            try
            {
                return Ok(studentRepository.GetAllStudents(std,section));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditStudent")]
        public IActionResult Edit(Student student)
        {
            try
            {
                studentRepository.UpdateStudent(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
                return Ok("Student Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
