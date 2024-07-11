using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo01
    {
        static void Main()
        {
            try
            {
                int[] a = { 12, 2, 34, 5, 56, 67, 78 };
                //print array values
                for(int i=0;i<20;i++)
                {
                    Console.WriteLine(a[i]);
                }
                //cleaning code
              
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Message: " + ex.Message); //built in message
                Console.WriteLine("Source: " + ex.Source); //retuns project name
                Console.WriteLine("Method: "+ex.TargetSite); //retruns metod name
                Console.WriteLine("ErrorInfo: "+ex.StackTrace); //retruns error complete info
                //clening c

            }
           
           
        }
    }
}
