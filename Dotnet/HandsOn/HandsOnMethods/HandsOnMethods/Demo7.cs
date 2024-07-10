using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo7
    {
        public static int Sum(params int []a)
        {
            int sum = 0;
            foreach (var i in a)
                sum = sum + i;
            return sum;

        }
        static void Main()
        {
            Sum(new int[] { 12, 23, 34, 55 });
            Sum(1, 2);
            Sum(1, 2,2);
            Sum(1, 2,3,4,5);
        }
    }
}
