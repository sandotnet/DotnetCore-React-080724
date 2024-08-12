namespace HandsOnAsynchronousprogramming
{
    internal class Program
    {
       public static void Method1()
        {
<<<<<<< HEAD
            Console.WriteLine("METHOD 1 Started..");
            Thread.Sleep(TimeSpan.FromSeconds(10)); //waits the code execution
=======
            Console.WriteLine("Method 1 Started..");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
>>>>>>> fa3f6e3f04414bedcc588644259a845364845a32
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
            // Method1();
            Method2();
            Method1();
            Console.WriteLine("Main Method End..");
            Console.ReadKey();
        }
    }
}
