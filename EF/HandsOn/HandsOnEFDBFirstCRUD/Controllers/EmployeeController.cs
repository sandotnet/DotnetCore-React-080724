using HandsOnEFDBFirstCRUD.Entities;
using HandsOnEFDBFirstCRUD.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDBFirstCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDb1Context myDb1Context;
        public EmployeeController()
        {
            myDb1Context = new MyDb1Context();
        }
        public IActionResult Index() //Display EmployeeDept Details
        {
            var items = from e in myDb1Context.EmployeeDetails
                        join d in myDb1Context.Departments
                        on e.DeptCode equals d.DeptCode
                        select new EmployeeVM()
                        {
                            EmpId = e.EmpId,
                            EmpName = e.EmpName,
                            Designation=e.Designation,
                            DeptName=d.DeptName
                        };
            return View(items);
        }
    }
}
