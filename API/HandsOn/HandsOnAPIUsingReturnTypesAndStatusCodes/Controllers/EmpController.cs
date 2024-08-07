using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingReturnTypesAndStatusCodes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        [HttpGet, Route("All")]
        public IActionResult GetAllEmployee()
        {
            var employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
             new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
              new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
               new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
                new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
            };
            if (employees.Any())
            {
                return Ok(employees);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet, Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
             new Employee() { Id = 2, Name = "Karan", City = "Pune", Age = 21, DepartMent = "IT" },
              new Employee() { Id = 3, Name = "Monica", City = "Pune", Age = 21, DepartMent = "IT" },
               new Employee() { Id = 4, Name = "Tina", City = "Pune", Age = 21, DepartMent = "IT" },
                new Employee() { Id = 5, Name = "Jay", City = "Pune", Age = 21, DepartMent = "IT" },
            };
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                return Ok(employee);
            else
                return NotFound(); //If employee does not exist
        }
        [HttpGet, Route("{eid:int}")]
        public ActionResult<Employee> GetEmployeeDetails(int eid)
        {
            if (eid == 0)
            {
                return NotFound();
            }
            else
            {
                return new Employee()
                {
                    Id = 5,
                    Name = "Jay",
                    City = "Pune",
                    Age = 21,
                    DepartMent = "IT"
                };
            }

        }
        [HttpGet, Route("{name:alpha}")]
        public OkObjectResult GetEmployeeDetailsByName(string name)
        {
            var item = new Employee()
            {
                Id = 5,
                Name = "Jay",
                City = "Pune",
                Age = 21,
                DepartMent = "IT"
            };
            return Ok(item); //directly returns OkObjectResult
        }
        [HttpDelete, Route("{employeeid:int}")]
        public void DeleteEmployee(int employeeid)
        {
            //Retruns 204 NoContent Respose.
        }
        public async Task<IActionResult> GetEmployeesAll()
        {
            var employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
             new Employee() { Id = 2, Name = "Karan", City = "Pune", Age = 21, DepartMent = "IT" },
              new Employee() { Id = 3, Name = "Monica", City = "Pune", Age = 21, DepartMent = "IT" },
               new Employee() { Id = 4, Name = "Tina", City = "Pune", Age = 21, DepartMent = "IT" },
                new Employee() { Id = 5, Name = "Jay", City = "Pune", Age = 21, DepartMent = "IT" },
            };
            return  Ok(employees);
        }
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram", City = "Pune", Age = 21, DepartMent = "IT" },
             new Employee() { Id = 2, Name = "Karan", City = "Pune", Age = 21, DepartMent = "IT" },
              new Employee() { Id = 3, Name = "Monica", City = "Pune", Age = 21, DepartMent = "IT" },
               new Employee() { Id = 4, Name = "Tina", City = "Pune", Age = 21, DepartMent = "IT" },
                new Employee() { Id = 5, Name = "Jay", City = "Pune", Age = 21, DepartMent = "IT" },
            };
            return Ok(employees);
        }

    }
}
