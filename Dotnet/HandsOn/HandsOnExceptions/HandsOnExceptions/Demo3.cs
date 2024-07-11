using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo3
    {
        static void Main()
        {
            try
            {
                int result;
                Console.WriteLine("Enter a, b values");
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                result = a / b;
                Console.WriteLine("Resullt: " + result);

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("b value should not be 0");
            }
            finally
            {
                Console.WriteLine("Good Morning EveryOne!!!");
            }
        }
    }
}
