using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo3
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
            //List Employees working as Programmer
            var result = from e in employees
                         where e.Designation == "Programmer"
                         select e;
            result = employees.Where(e => e.Designation == "Programmer").ToList();
            foreach(var item in result)
                Console.WriteLine(item);
            //return only Ids of employee with asc
            var r1 = from e in employees
                     orderby e.Id ascending
                     select e.Id;
            foreach (var item in r1)
                Console.WriteLine(item);
            //return Id and Name
            var r2 = from e in employees
                     orderby e.Name descending
                     select new { Id = e.Id, Name = e.Name };
            foreach(var item in r2)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name}");
            }
            //convert result set into list
            List<Employee> l1 = (from e in employees
                                 where e.Salary > 40000
                                 select e).ToList();
            //convert resultset into array
            Employee[] l2 = employees.Where(e => e.Designation == "Sr Programmer").ToArray();
            //eliminate duplicates using Distinct()
            string[] designation = (from e in employees
                                    select e.Designation).Distinct().ToArray();
            //List employees joined in 2021
            List<Employee> l3 = employees.Where(e => e.JoinDate.Year == 2021).ToList();
            List<Employee> l4 = employees.Where(e => e.JoinDate == DateTime.Parse("5.23.2023")).ToList();
                
        }
    }
}
