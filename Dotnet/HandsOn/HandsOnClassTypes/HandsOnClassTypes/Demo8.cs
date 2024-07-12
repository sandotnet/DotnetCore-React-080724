using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class Test
    {
        public int a;
    }
    internal class Demo8
    {
        static void Main()
        {
            Test t1=new Test();
            t1.a = 10;
            Test t2=new Test ();
            t2.a = 100;
        }
    }
}
