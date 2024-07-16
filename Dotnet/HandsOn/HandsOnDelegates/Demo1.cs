using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    //delegate can refer multiple methods
    public delegate void MathDelegate(int a, int b);
    internal class Demo1
    {
        public static void Add(int a, int b) {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main()
        {
            MathDelegate m1 = Add;
            //add one more method reference to m1 object
            m1 += Mul;
            //invoke delegate
            m1(10, 20);
                
        }
    }
}
