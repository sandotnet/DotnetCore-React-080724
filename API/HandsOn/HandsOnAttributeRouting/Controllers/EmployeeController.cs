using HandsOnAttributeRouting.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAttributeRouting.Controllers
{

    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        //[Route("Employee/GetAll")]
        [Route("GetAll")]
        public string GetAllEmployees()
        {
            return "Return All Employees";
        }
        //[HttpGet,Route("Employee/Get/{id}")]
        [HttpGet, Route("Get/{id}")]
        public string GetEmployee(int id)
        {

            return $"Retrun Employee:{id}";
        }
        //[HttpDelete, Route("Employee/Delete/{id}")]
        [HttpDelete, Route("Delete/{id}")]
        public string DeleteEmployee(int id)
        {
            return $"Deleted Employee :{id}";
        }
        [HttpGet,Route("GetEmployeeByProjectAndLocation/Project/{project}/Location/{location}")]
        public string GetEmployeeByProjectAndLocation(string project,string location)
        {
            return $"Retrun Employees with Project:{project},Location:{location}";
        }
        [HttpGet,Route("Search")]
        public string SearchEmployees(string Department)
        {
            return $"Return Employees with Dept:{Department} ";
        }
        [HttpPost,Route("AddEmployee")]
        public string Add(Employee employee)
        {
            return "Add Employees";
        }
        [HttpPut, Route("Edit")]
        public string Update([FromQuery]Employee employee)
        {
            return "Employee Updated";
        }
        [HttpGet,Route("GetEmployeeWithDept/{department}")]
        public string GetEmployeeByDeptAndLocation(string department, string location)
        {
            return "Employee with Dept and Location";
        }
    }
}
