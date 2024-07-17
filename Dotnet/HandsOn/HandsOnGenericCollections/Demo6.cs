using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo6
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            //add items to the stack
            stack.Push(1);
            stack.Push(2);
                stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //accesss top value
            int k = stack.Peek(); //Peek() returns top value
            Console.WriteLine("Top Value: "+k);
            //remove top value
            k=stack.Pop(); //Pop() retruns and remove value
            Console.WriteLine("Removed Value: " + k);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
