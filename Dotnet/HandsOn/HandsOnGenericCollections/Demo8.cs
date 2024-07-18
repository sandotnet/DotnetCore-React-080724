using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo8
    {
        static void Main()
        {
            //anonymous object
            var obj = new { Id = 1, Name = "Rohan", Age = 10 };
            Console.WriteLine($"ID:{obj.Id} Name:{obj.Name} Age:{obj.Age}");
        }
    }
}
