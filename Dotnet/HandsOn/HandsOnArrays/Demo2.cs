using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo2
    {
        static void Main()
        {
            int[] nos = { 12, 23, 34, 45, 56, 67, 78, 89, 99, 21, 32, 43, 54, 65, 76 };
            Console.WriteLine("Guess the no");
            int k = int.Parse(Console.ReadLine());
            bool result = false;
            foreach (int i in nos)
            {
                if (i == k)
                {

                    result = true;
                    break; //stop foreach execution
                }

            }
            if (result == false)
            {
                Console.WriteLine("Looser!!!");

            }
            else
                Console.WriteLine("Winner!!!");
        }
    }
}