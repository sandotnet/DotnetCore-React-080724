using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance1
{
    class Employee
    {
        public int eid;
        public string ename;
        public double salary;

        public Employee(int eid, string ename, double salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
        }

        public virtual  void Details()
        {
            Console.WriteLine($"Eid:{eid} Ename:{ename} Salary:{salary}");
        }
    }
    class Manager:Employee
    {
        public string level;
        public string[] projects;

        public Manager(int eid, string ename, double salary,string level, string[] projects):base(eid,ename,salary)
        {
            this.level = level;
            this.projects = projects;
        }
        //public override void Details()
        //{
        //    base.Details();
        //    Console.WriteLine($"Level Of Manager:{level}");
        //    Console.WriteLine("Projects Handled:");
        //    foreach(var k in projects)
        //    {
        //        Console.Write(k + " ");
        //    }
        //}
    }
    class Demo8
    {
        static void Main()
        {
            Employee employee = null;
            Console.WriteLine("1.Programmer");
            Console.WriteLine("2.Manager");
            Console.WriteLine("Select Designation");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    employee =new Employee(23356, "Jo", 23000);
                    employee.Details();
                    break;
                case 2:
                    employee = new Manager(43032, "Rohan", 50000, "Level2", new string[] { "Project1", "Project2", "Project3" });
                    employee.Details(); //invoke Manager Details()
                    break;

            }
           
            
        }
    }
}
