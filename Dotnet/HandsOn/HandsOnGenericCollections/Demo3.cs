using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo3
    {
        static void Main()
        {
            Dictionary<int,string> obj = new Dictionary<int,string>();
            //add values to dictionary
            obj.Add(4320, "Rohith");
            obj.Add(4566, "Adarsh");
            obj.Add(4213, "Rohan");
            obj.Add(1234, "Madhu");
            string n = obj[1234]; //returns value of the key
            //remove key value pair
            obj.Remove(4213);
            //get all key value paris
            foreach(int k in obj.Keys)
            {
                Console.WriteLine($"Key:{k} Value:{obj[k]}");
            }
            if(obj.ContainsKey(1234))
            {
                Console.WriteLine("Name: " + obj[1234]);
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }
    }
}
