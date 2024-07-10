using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    //MEthod overloading
    class Demo5
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public static double Add(double a,double b)
        {
            return a + b;
        }
        public static double Add(float a, float b)
        {
            return a + b;
        }
        static void Main()
        {
            Add(1, 2);
            Add(12.2, 23.3);
            Add(12d, 10d);
            Add(12, 23, 34);
            Add(23, 45);
            Add(23f, 45.6f);
        }
    }
}
