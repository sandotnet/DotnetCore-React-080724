using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndOjects
{
    internal class Employee
    {
        public int employeeId;
        public string employeeName;
        public const string company="FINT";
        public static string project;
        public static string client;
        public void Details()
        {
            Console.WriteLine($"Id:{employeeId} Name:{employeeName} Company:{company} Project: {project} " +
                $"Client: {client}");
        }
        static void Main()
        {
            //access static data
            Console.WriteLine($"Employees working in {Employee.company}");
            Employee.client = "Microsoft";
            Employee.project = "EduApp";
            Employee e1 = new Employee() { employeeId = 323, employeeName = "Charan" };
            Employee e2 = new Employee() { employeeId = 456, employeeName = "Kiran" };
            Employee e3 = new Employee() { employeeId = 123, employeeName = "Saran" };
            e1.Details();
            e2.Details();
            e3.Details();
            Employee.project = "ECommApp";
            Employee e4 = new Employee() { employeeId = 432, employeeName = "Gita" };
            Employee e5 = new Employee() { employeeId = 321, employeeName = "Sita" };
            Employee[]employees=new Employee[2] {e4,e5};
            foreach (var employee in employees)
            {
                employee.Details();
            }
        }
    }
}
