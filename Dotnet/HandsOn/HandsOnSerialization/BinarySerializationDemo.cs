using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace HandsOnSerialization
{
    class BinarySerializationDemo
    {
        public static void Serialization()
        {
            try
            {
                Employee employee = new Employee() { Eid = 1001, Ename = "Suren", Desig = "Programmer" };
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D://emp.bat", 
                    FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, employee);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Employee Deserialize()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D://emp.bat", FileMode.Open, FileAccess.Read))
                {
                    Employee employee = formatter.Deserialize(stream) as Employee;
                    return employee;
                }

                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               throw ex;
            }
        }
        static void Main()
        {
            //Serialization();
           Employee employee = Deserialize();
           Console.WriteLine($"{employee.Eid} {employee.Ename}");
            Console.ReadKey();
        }
    }
}
