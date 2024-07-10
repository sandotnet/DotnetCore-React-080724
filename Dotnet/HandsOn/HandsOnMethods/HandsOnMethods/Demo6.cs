using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo6
    {
        public static void M(int a)
        {
            a = 2 * a;
            Console.WriteLine("a= " + a);
        }
        public static void M1(ref int a)
        {
            a = 2 * a;
            Console.WriteLine("a= " + a);
        }
        public static void Sum(int a,int b,out int c)
        {
            c = a + b;
        }
        static void Main()
        {
            int a=10;
            M(a);
            Console.WriteLine(a); //10;
            M1(ref a);
            Console.WriteLine(a);
            int k=10, b = 20, c; //c is out variable it is not requierd to initizlize
            Sum(k, b, out c);
            Console.WriteLine(c);

        }
    }
}
