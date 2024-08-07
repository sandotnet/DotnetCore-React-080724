using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnConventionalRouring.Controllers
{
    
    public class EmployeeController : ControllerBase
    {
        //action methods
        [HttpGet]
        public string GetAllEmployees()
        {
            return "Retrun all The Employees";
        }
        [HttpGet]
        public string GetEmployeeById(int id)
        {
            return $"Retrun Employee Details:{id}";
        }

    }
}
