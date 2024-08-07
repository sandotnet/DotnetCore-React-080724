using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsynchronousprogramming
{
    internal class Demo1
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(100).Wait();
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method 2");
                Task.Delay(100).Wait(); //do something
            }
        }
        public static void Main()
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
    }
}