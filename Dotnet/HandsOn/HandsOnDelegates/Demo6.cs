using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate int CubeDelegate(int i);
    internal class Demo6
    {
        public static int Cube(int i)
        {
            return i * i * i;
        }
        static void Main()
        {
            CubeDelegate d1 = Cube;
            int result=d1(3);
            CubeDelegate d2 = delegate (int i) //anonymouse method
            {
                return i * i * i;
            };
            result = d2(4);
            CubeDelegate d3=(i)=>i* i*i; //lambda expression
            Console.WriteLine(d3(5));
                
        }
    }
}
