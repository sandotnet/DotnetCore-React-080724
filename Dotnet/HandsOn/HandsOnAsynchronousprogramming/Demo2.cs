using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsynchronousprogramming
{
    internal class Demo2
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    count++;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2");
                
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total Count: "+count);
        }
        public static async Task CallingMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }
        public static async  Task Main()
        {
            await CallingMethod();

        }
    }
}
