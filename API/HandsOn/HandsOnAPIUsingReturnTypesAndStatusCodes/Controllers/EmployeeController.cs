using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingReturnTypesAndStatusCodes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet,Route("GetName")]
        public string GetName()
        {
            return "Retrun from GetName";
        }
        [HttpGet,Route("Details")]
        public Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Name="Ram",
                Age=20,
                City="Pune",
                Gender="Male",
                DepartMent="IT"
            };
        }
        [HttpGet,Route("All")]
        public List<Employee> GetEmployees()
        {
            return new List<Employee>() { 
            new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
             new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
              new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
               new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
                new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
            };
        }

        [HttpGet, Route("GetAll")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return new List<Employee>() {
            new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
             new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
              new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
               new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
                new Employee(){Id=1,Name="Ram",City="Pune",Age=21,DepartMent="IT"},
            };
        }
    }
}
