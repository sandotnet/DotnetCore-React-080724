using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo4
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3]; //two-dimensional array
            //assign values
            matrix[0, 0] = 11;
            matrix[0, 1] = 12;
            matrix[0, 2] = 12;

            matrix[1, 0] = 13;
            matrix[1, 1] = 14;
            matrix[1, 2] = 14;

            matrix[2, 0] = 15;
            matrix[2, 1] = 16;
            matrix[2, 2] = 14;
            //print array values
            foreach (var i in matrix)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //print values in matrix form
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
