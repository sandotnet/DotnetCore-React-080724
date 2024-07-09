using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversions
{
    internal class Demo3
    {
        static void Main()
        {
            int i = 34;
            short s = 300;
            byte b = 20;
            //boxing(convert any value type to object) is a implicit conversion
            object o1 = i;
            object o2 = s;
            object o3 = b;
            //unboxing(convert object to any value type) is required explicit conversion
            object o4 = 123;
            int k = (int)o4;
            int j = Convert.ToInt32(o4);
            object o5 = 344.45;
            double d = (double)o5;
            double d1=Convert.ToDouble(o5);

        }
    }
}
