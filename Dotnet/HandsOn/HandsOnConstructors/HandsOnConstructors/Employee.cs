using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    internal class Employee
    {
        private Employee()
        {
            
        }
        public static Employee GetObject()
        {
            Employee employee = new Employee();
            return employee;
        }
    }
    class Test_Employee
    {
        static void Main()
        {
            Employee obj = Employee.GetObject();
            //Employee obj1 = new Employee(); 
        }
    }
}
