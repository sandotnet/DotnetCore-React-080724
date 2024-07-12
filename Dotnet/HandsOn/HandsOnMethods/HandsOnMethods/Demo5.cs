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
        public  int Add(int a,int b)
        {
            return a + b;
        }
        public  int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public  double Add(double a,double b)
        {
            return a + b;
        }
        public  double Add(float a, float b)
        {
            return a + b;
        }
        static void Main()
        {
            Demo5 obj=new Demo5();
            obj.Add(1, 2);
            obj.Add(12.2, 23.3);
            obj.Add(12d, 10d);
            obj.Add(12, 23, 34);
            obj.Add(23, 45);
            obj.Add(23f, 45.6f);
        }
    }
}
