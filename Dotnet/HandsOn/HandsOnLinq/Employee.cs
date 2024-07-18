using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public string ProjectCode { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} JoinDate:{JoinDate} " +
                $"Salary:{Salary} Designation:{Designation}";
        }
    }
}
