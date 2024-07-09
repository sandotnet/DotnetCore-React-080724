using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo1
    {
        static void Main()
        {
            string[] flowers = new string[4];
            //read values from input
            for(int i=0;i<4;i++)
            {
                Console.Write($"Enter flower[{i}] ");
                flowers[i] = Console.ReadLine(); //assing value to the array
            }
            //print array values using foreach
            foreach(string flower in flowers)
            {
                Console.WriteLine(flower);
            }
            //print array values using for
            Console.WriteLine();
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(flowers[i]);
            }

        }
    }
}
