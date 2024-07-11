using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo0
    {
        static void Main()
        {
            int[] n = { 12, 23, 34, 45, 56 };
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(n[i]);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                //handle excetions here
                Console.WriteLine("Array Index out of range.");
            }
        }
    }
}
