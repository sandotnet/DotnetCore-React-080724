using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsynchronousprogramming
{
    internal class Demo0_Synchronous
    {
        public static void StartSchoolAssembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Started");
        }
        public static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");

        }
        public static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");

        }
        public static void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            StartSchoolAssembly();
            TeachClass12();
            TeachClass11();
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds}ms");
        }
        static void Main(string[] args)
        {
            Demo();
            Console.ReadLine();

        }
    }
    internal class Demo0_Asynchronous
    {
        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }
        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12");
            });


        }
        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 11");
            });

        }
        public static  async void Demo()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var task1 = StartSchoolAssembly();
            //await task1; //Let us wait for the school assembly to finish irrespective of how long it is taking and later the teaching for classes 11 and 12 can begin.
            var task2 = TeachClass12();
            var task3 = TeachClass11();
            Task.WaitAll(task1, task2, task3); //methods run parallelly
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds}ms");
        }
        static void Main(string[] args)
        {
            Demo();
            Console.ReadLine();

        } 
    }
}
