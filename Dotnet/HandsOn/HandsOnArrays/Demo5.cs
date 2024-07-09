using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo5
    {
        static void Main()
        {
            //Jagged array
            int[][] ja = new int[3][];
            ja[0] = new int[4] { 3, 4, 5, 6 };
            ja[1] = new int[3] { 8, 7, 5 };
            ja[2] = new int[2] { 1, 2 };
            //access value
            Console.WriteLine(ja[1][0]);  
            //access 1st array values
            foreach(var k in ja[0])
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            for(int i=0; i < 3; i++)
            {
                foreach (var k in ja[i])
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
