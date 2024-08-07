namespace HandsOnAsynchronousprogramming
{
    internal class Program
    {
       public static void Method1()
        {
            Console.WriteLine("Method 1 Started..");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Method 1 End..");
        }
        public async static void Method2()
        {
            
            Console.WriteLine("Method 2 Started..");
            /*
             Task.Dealy() executed, it will free the current thread, and then that 
            current thread comes and execute the rest of the code inside the main method. 
            And after 10 seconds again thread come back to the
            Method2 and execute the rest of the code inside the Method2.
             */
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("Method 2 End..");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started...");
            //Method1();
            Method2();
            Console.WriteLine("Main Method End..");
            Console.ReadKey();
        }
    }
}
