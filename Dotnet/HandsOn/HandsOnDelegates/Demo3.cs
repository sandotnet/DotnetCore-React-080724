using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void CustomDelegate();
    internal class Demo3
    {
        public Demo3()
        {
            
        }
        public Demo3(CustomDelegate customDelegate)
        {
            customDelegate();
        }
        //function call back(calling function by passing other function as a parameter)
        public void Callback(CustomDelegate customDelegate)
        {
            //invoking delegate
            customDelegate();
        }
        public void Task()
        {
            Console.WriteLine("Task is Running");
        }
        public void Greet()
        {
            Console.WriteLine("Hello Users");
        }
        static void Main()
        {
            Demo3 obj = new Demo3();
            obj.Callback(obj.Task);
            obj.Callback(obj.Greet);
            obj.Callback(() => Console.WriteLine("Hello " + "Virat"));
            Demo3 obj2= new Demo3(obj.Task);
            Demo3 obj4= new Demo3(()=>Console.WriteLine("Operation in Process!!!"));

        }
    }
}
