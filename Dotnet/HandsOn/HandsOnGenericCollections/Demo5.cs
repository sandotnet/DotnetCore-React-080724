using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo5
    {
        static void Main()
        {
            //items are stored in sorted order of the key
            SortedDictionary<int,string> obj= new SortedDictionary<int,string>();
            obj.Add(4320, "Rohith");
            obj.Add(4566, "Adarsh");
            obj.Add(4213, "Rohan");
            obj.Add(1234, "Madhu");
            foreach(KeyValuePair<int,string> kvp in obj)
            {
                Console.WriteLine($"ID:{kvp.Key} Value:{kvp.Value}");
            }
        }
    }
}
