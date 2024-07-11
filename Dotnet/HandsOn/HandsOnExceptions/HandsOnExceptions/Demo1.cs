using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo1
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = 0;
                if (b == 0)
                {
                    throw new DivideByZeroException("b should not be 0");
                }
                else
                {
                   result = a / b;
                }

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("b shold not be 0");
            }
            catch(FormatException ex)
            {

            }
            catch(Exception ex) //handle all the types of exceptions.
            {

            }
            Console.ReadKey();
        }
    }
}
