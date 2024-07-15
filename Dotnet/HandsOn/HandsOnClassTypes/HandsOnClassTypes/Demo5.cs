using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    partial class Employee
    {
        public object GetEmployee(int id)
        {
            return null;
        }
        public void DeleteEmployee(int id)
        {

        }
        public void UpdateEmployee(object employee)
        {

        }
      static void Main()
        {
            Employee obj = new Employee();
            obj.AddEmployee();
            obj.DeleteEmployee(1);
            obj.GetEmployees();
            
        }
    }
}
