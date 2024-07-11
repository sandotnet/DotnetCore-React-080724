using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo4
    {
        public static int Sum(int a,int b)
        {
            try
            {
                int c = a + b;
                return c;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
                //return 0;
            }
            finally
            {
                Console.WriteLine("Good Morning EveryOne!!");
            }
        }
        static void Main()
        {

            try
            {
                Console.WriteLine(Sum(12, 2));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
