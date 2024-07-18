using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo5
    {
        static void Main()
        {
            List<Project> projects = new List<Project>()
            {
                new Project(){ProjectCode="P0001",ProjectName="EComm"},
                 new Project(){ProjectCode="P0002",ProjectName="SMS"},
             new Project(){ProjectCode="P0003",ProjectName="HCare"},
            };
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=234,Name="Saran",JoinDate=new DateTime(2023,2,23),Salary=34000,Designation="Programmer",ProjectCode="P0001"},
                 new Employee(){Id=321,Name="Charan",JoinDate=new DateTime(2021,12,3),Salary=75000,Designation="TeamLead",ProjectCode="P0002"},
                  new Employee(){Id=654,Name="Ram",JoinDate=new DateTime(2023,5,13),Salary=55000,Designation="Sr Programmer",ProjectCode="P0001"},
                   new Employee(){Id=987,Name="Rohith",JoinDate=new DateTime(2023,4,3),Salary=34000,Designation="Programmer",ProjectCode="P0002"},
                    new Employee(){Id=912,Name="Raj",JoinDate=new DateTime(2020,1,13),Salary=39000,Designation="Programmer",ProjectCode="P0003"},
                     new Employee(){Id=823,Name="Tina",JoinDate=new DateTime(2022,2,23),Salary=41000,Designation="Sr Programmer",ProjectCode="P0001"},
                      new Employee(){Id=713,Name="Rada",JoinDate=new DateTime(2030,3,24),Salary=900000,Designation="TeamLead",ProjectCode="P0003"},
                       new Employee(){Id=665,Name="Karan",JoinDate=new DateTime(2022,4,2),Salary=43000,Designation="Programmer",ProjectCode="P0002"},
                        new Employee(){Id=223,Name="Suraj",JoinDate=new DateTime(2023,5,13),Salary=54000,Designation="Sr Programmer",ProjectCode="P0001"},
                         new Employee(){Id=654,Name="Sai",JoinDate=new DateTime(2021,6,21),Salary=24000,Designation="Programmer",ProjectCode="P0003"},
                          new Employee(){Id=789,Name="Sita",JoinDate=new DateTime(2024,7,23),Salary=24000,Designation="Programmer",ProjectCode="P0002"},
                           new Employee(){Id=122,Name="Geeta",JoinDate=new DateTime(2021,8,3),Salary=64000,Designation="Sr Programmer",ProjectCode="P0001"},
            };
            var result = from p in projects
                         join e in employees
                         on p.ProjectCode equals e.ProjectCode
                         select new { Id=e.Id,Name=e.Name,ProjectName=p.ProjectName};
            foreach (var item in result)
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Project:{item.ProjectName}");

        }
    }
}
