using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Program
    {
        static void Main(string[] args)
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
            catch (FormatException ex)
            {
                Console.WriteLine("enter only no's");

            }
            catch (Exception ex) //handle rest of the exceptions
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
