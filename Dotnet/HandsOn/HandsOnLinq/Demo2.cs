using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo2
    {
        static void Main()
        {
            //let is used to create temp variable in query syntax
            int[] n = { 13, 14, 45, 56, 56, 7, 67, 78, 89 };
            var result = from k in n
                         let m = k * k * k
                         where m > 100 && m < 10000
                         select m;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
