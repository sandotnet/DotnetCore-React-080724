using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo7
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            //add items
            queue.Enqueue("Rose");
            queue.Enqueue("Lilly");
            queue.Enqueue("Jasmine");
            queue.Enqueue("Tulips");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First Value: " + queue.Peek());
            Console.WriteLine("Removed Value: " + queue.Dequeue());
            Console.WriteLine();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}