using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversions
{
    internal class Demo2
    {
        static void Main()
        {
            //numeric conversion
            int i = Convert.ToInt32("123");
            short s=Convert.ToInt16("123");
            byte b=Convert.ToByte("123");
            long l=Convert.ToInt64("34567");
            double d=Convert.ToDouble("123.34");
            float f = Convert.ToSingle("34.45");
            decimal d1 = Convert.ToDecimal("89.3333334");
            char ch = Convert.ToChar("S");
            char ch1 = Convert.ToChar(23);
            bool b1 = Convert.ToBoolean("true");
            Console.WriteLine(ch1);
            string s1 = Convert.ToString(3456);
            Console.WriteLine(s1);
            

        }
    }
}
