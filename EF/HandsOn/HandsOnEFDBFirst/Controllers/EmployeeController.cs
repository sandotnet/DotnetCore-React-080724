using HandsOnEFDBFirst.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDBFirst.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDb1Context myDb1Context;
        public EmployeeController()
        {
            myDb1Context = new MyDb1Context();
        }
        public IActionResult Index() //Get All Employees
        {
            var employees=myDb1Context.EmployeeDetails.ToList(); //retrun all the employees in the List
            return View(employees);
        }
        public IActionResult Details(int employeeId)
        {
            var employee=myDb1Context.EmployeeDetails.SingleOrDefault(e=>e.EmpId==employeeId);
            return View(employee);
        }
    }
}
