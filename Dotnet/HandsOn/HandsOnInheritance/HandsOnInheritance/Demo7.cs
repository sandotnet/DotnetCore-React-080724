using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Method-hiding in Inheritance
    class Employee
    {
        public int eId;
        public string eName;
        public void Details()
        {
            Console.WriteLine("ID: " + eId);
            Console.WriteLine("Ename: " + eName);
        }
    }
    class Manager:Employee
    {
        public string type;
         new public void Details()
        {
            base.Details(); //calls Employee Details()
            Console.WriteLine("Manager Type: " + type);
        }
    }
    class ProjectManager:Manager
    {
         new public void Details()
        {
            base.Details(); //invoke Manager Details
        }
    }
    class Demo7
    {
        static void Main()
        {
            Manager obj = new Manager();
            obj.eId = 1000;
            obj.eName = "Jon";
            obj.type = "Product Manager";
            obj.Details(); //invoking details of Manager
            Employee e1=new Employee();
            Employee ob1 = new Manager(); //object of Employee instance of Manager
            ob1.eId = 1001;
            ob1.eName = "Jeson";
           
            ob1.Details();
        }
    }
}
