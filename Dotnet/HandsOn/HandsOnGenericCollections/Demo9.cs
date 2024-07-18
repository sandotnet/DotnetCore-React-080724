using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo9
    {
        static void Main()
        {
            int k = 10;
           
            Console.WriteLine(k.GetType());
            string s = "David";
            Console.WriteLine(s.ToUpper());
            Product p = new Product();
            Console.WriteLine(p.GetType());
        }
    }
}
