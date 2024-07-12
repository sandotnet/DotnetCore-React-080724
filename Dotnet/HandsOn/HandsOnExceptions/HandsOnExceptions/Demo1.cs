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
                Console.WriteLine("Enter b value");
                int b =int.Parse(Console.ReadLine());
                int result = 0;
                if (b == 0)
                {
                    DivideByZeroException obj=new DivideByZeroException("b value should not 0");
                    throw obj;
                   // throw new DivideByZeroException("Dont be enter 0 for b");
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
            }
            
            catch(Exception ex) //handle all the types of exceptions.
            {

            }
          
        }
    }
}
