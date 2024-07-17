using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void MDelegate();
    public delegate void MessageDelegate(string name);
    internal class Demo4
    {
        public void Task()
        {
            Console.WriteLine("Task is Running..");
        }
        static void Main(string[] args)
        {
            Demo4 demo = new Demo4();
            MDelegate obj = demo.Task;
            obj(); //invoking delegate object
            MDelegate obj1 = delegate () //anonymous method
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello Users");
                }
            };
            obj1(); //calling delegate
            MessageDelegate m1 = delegate (string name) //anonymous method
            {
                Console.WriteLine("Hello " + name);
            };
            m1("Virat"); //calling delegate
            MessageDelegate m2 = (n) => Console.WriteLine("Hello " + n); //lamda expression
            m2("Rohith");
        }
    }
}
