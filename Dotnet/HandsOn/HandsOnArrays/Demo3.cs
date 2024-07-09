using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo3
    {
        static void Main()
        {
            string[] cities = new string[5] { "Hyderabad", "Chennai", "Pune", "Banglore", "Mumbai" };
            Console.WriteLine("Count: " + cities.Length);
            Console.WriteLine("Rank: " + cities.Rank);
            //sort array 
            Array.Sort(cities);
            string[] s = new string[3];
            //copy array
            Array.Copy(cities, s, s.Length);
            foreach(var c in cities)
            {
                Console.WriteLine(c);
            }
            //reverse array elements
            Console.WriteLine();
            //Array.Reverse(cities);
            //foreach (var c in cities)
            //{
            //    Console.WriteLine(c);
            //}
            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine();
            if(Array.BinarySearch(cities, city)>=0)
            {
                Console.WriteLine(" City in the List");
            }
            else
            {
                Console.WriteLine("City not in the List");
            }

            
        }
    }
}
