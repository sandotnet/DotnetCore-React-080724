using System.Collections.Generic;
namespace HandsOnGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1= new List<int>(); //instantiate list
            List<string> l2 = new List<string>() { "Orange", "Banana" }; //collection initializer
            l2.Add("Apple");
            //add items
            l1.Add(34);
            l1.Add(45);
            l1.Add(56);
            l1.Add(80);
            Console.WriteLine("No of Items: " + l1.Count);
            l1.Add(55);
            Console.WriteLine("No of Items: " + l1.Count);
            l1.Remove(45); //remove item
            Console.WriteLine("No of Items: " + l1.Count);
            //access item
            int k = l1[2];
            foreach (int i in l1)
                Console.WriteLine(i);
            l1.Sort();
            Console.WriteLine();
            foreach (int i in l1)
                Console.WriteLine(i);

        }
    }
}
