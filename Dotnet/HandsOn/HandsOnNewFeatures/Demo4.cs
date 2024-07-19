using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNewFeatures
{
    internal class Demo4
    {
        public dynamic employeeId; //class variable
        public dynamic Mul(dynamic a, dynamic b) //method parameter and return type
        {
            return a * b;
        }
        static void Main()
        {
            dynamic a = 10; //local variable
            a = 23.34;
            a = "David";
            string s = a;
            int k = a; //runtime error(No compile time check)
            var v = "Hari";
            //k = v; //compiletime error
            object o = "Jo";
            //k = o; // compiletime error
        }
    }
}
