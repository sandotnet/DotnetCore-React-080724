using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;
using System.IO;
namespace HandsOnSerialization
{
    [Serializable]
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Desig { get; set; }
        static void Main()
        {
            Employee e1 = new Employee();
            e1.Eid = 1000;
            e1.Ename = "Rohan";
            e1.Desig = "TeamLeader";
            Employee e2 = new Employee() { Eid = 1001, Ename = "Suren", Desig = "Programmer" };
            Employee e5 = new Employee() { Eid = 1002, Ename = "Karan", Desig = "TeamLeader" };
            Employee e3 = new Employee() { Eid = 1003, Ename = "Jeson", Desig = "ProjectManager" };
            Employee e4 = new Employee() { Eid = 1004, Ename = "Mohan", Desig = "Programmer" };
            List<Employee> EmpList = new List<Employee>() { e1, e2, e3, e4, e5 };
            XmlSerializer obj = new XmlSerializer(typeof(List<Employee>));
            obj.Serialize(new StreamWriter("D:/emplist.xml"), EmpList);
        }
    }
}
