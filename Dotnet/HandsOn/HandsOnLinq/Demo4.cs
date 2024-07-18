using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo4
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=234,Name="Saran",JoinDate=new DateTime(2023,2,23),Salary=34000,Designation="Programmer"},
                 new Employee(){Id=321,Name="Charan",JoinDate=new DateTime(2021,12,3),Salary=75000,Designation="TeamLead"},
                  new Employee(){Id=654,Name="Ram",JoinDate=new DateTime(2023,5,13),Salary=55000,Designation="Sr Programmer"},
                   new Employee(){Id=987,Name="Rohith",JoinDate=new DateTime(2023,4,3),Salary=34000,Designation="Programmer"},
                    new Employee(){Id=912,Name="Raj",JoinDate=new DateTime(2020,1,13),Salary=39000,Designation="Programmer"},
                     new Employee(){Id=823,Name="Tina",JoinDate=new DateTime(2022,2,23),Salary=41000,Designation="Sr Programmer"},
                      new Employee(){Id=713,Name="Rada",JoinDate=new DateTime(2030,3,24),Salary=900000,Designation="TeamLead"},
                       new Employee(){Id=665,Name="Karan",JoinDate=new DateTime(2022,4,2),Salary=43000,Designation="Programmer"},
                        new Employee(){Id=223,Name="Suraj",JoinDate=new DateTime(2023,5,13),Salary=54000,Designation="Sr Programmer"},
                         new Employee(){Id=654,Name="Sai",JoinDate=new DateTime(2021,6,21),Salary=24000,Designation="Programmer"},
                          new Employee(){Id=789,Name="Sita",JoinDate=new DateTime(2024,7,23),Salary=24000,Designation="Programmer"},
                           new Employee(){Id=122,Name="Geeta",JoinDate=new DateTime(2021,8,3),Salary=64000,Designation="Sr Programmer"},
            };
            //First() returns first record in the sequence
            Employee e = employees.First(); //first record
            Console.WriteLine(e);
            e = employees.First(e => e.Designation == "Sr Programmer");
            Console.WriteLine(e);
            e = employees.Last(e => e.Salary > 30000);
            Console.WriteLine(e);
            e = employees.FirstOrDefault(e => e.Designation == "Admin");
            Console.WriteLine(e);
            Employee e1 = employees.Single(e => e.Id == 987);
             //e1 = employees.Single(e => e.Designation == "Programmer"); //exception
            Console.WriteLine(e1);
            //SingleOrDefault() return null when sequence contains no records.
            e1 = employees.SingleOrDefault(e => e.Id == 1987);
            Console.WriteLine(e1);
            e1 = employees.Where(e => e.Designation == "Programmer").ElementAt(3);
            Console.WriteLine(e1);
            Console.Clear();
            //grouping employees using their designation
            var result2 = from item in employees
                          group item by item.Designation;
            foreach (var items in result2)
            {
                Console.WriteLine("Employee working as {0}",items.Key); //here K retrun the value of Designation
                foreach(var employee in items)
                {
                    Console.WriteLine(employee.Name);
                }
            }

        }
    }
}
