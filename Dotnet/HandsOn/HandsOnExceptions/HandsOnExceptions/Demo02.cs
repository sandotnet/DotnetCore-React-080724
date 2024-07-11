using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo02
    {
        static void Main()
        {
            try
            {
                int a, b, res;
                a = 10;
                b = 0;
                if (b == 0)
                    //throw new DivideByZeroException();
                    throw new DivideByZeroException("b value should not 0");
                res = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
