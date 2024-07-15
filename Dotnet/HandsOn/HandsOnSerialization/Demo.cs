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
    class Demo
    {
        static void Main()
        {
            XmlSerializer obj = new XmlSerializer(typeof(Employee));
            Employee e=(Employee)obj.Deserialize(new StreamReader("D:/emp.xml"));
            Console.WriteLine("{0} {1} {2}", e.Eid, e.Ename, e.Desig);
        }
    }
}
