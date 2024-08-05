using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsynchronousprogramming
{
    internal class Demo3
    {
        public static async Task<int> ReadFile(string path)
        {
            int length = 0;
            Console.WriteLine("File reading is starting..");
            using (StreamReader sr = new StreamReader(path))
            {
                string s=await sr.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed..");
            return length;

        }
        public static async Task CallingMethod()
        {
            string filepath = "D:\\Desktop-1\\topics_to_learn.txt";
            Task<int> task=ReadFile(filepath);
            Console.WriteLine("Other Work 1");
            Console.WriteLine("Other Work 2");
            Console.WriteLine("Other Work 3");
            int length = await task;
            Console.WriteLine("Total Length :" + length);
            Console.WriteLine("After Work 1");
            Console.WriteLine("After Work 2");
        }
        public static async Task Main()
        {
            await CallingMethod();
        }
    }
}
