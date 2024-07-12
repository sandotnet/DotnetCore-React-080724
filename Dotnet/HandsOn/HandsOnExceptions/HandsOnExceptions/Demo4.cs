using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo4
    {
        public static int Div(int a,int b)
        {
            try
            {
                int c = a / b;
                return c;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
              
            }
           
        }
        static void Main()
        {

            try
            {
                Console.WriteLine(Div(12, 10));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
