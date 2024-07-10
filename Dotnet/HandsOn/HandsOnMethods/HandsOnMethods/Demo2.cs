using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{

    class Demo2
    {
        public void Add(int a,int b=9)
        {
            int c = a + b; //here c is a local variable
            Console.WriteLine("Addition: " + c);
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Sum(int []a)
        {
            int sum = 0; //local variable
            foreach(var k in a)
            {
                sum = sum + k;
            }
            Console.WriteLine("Sum= " + sum);
        }
        public void IsEven(int no)
        {
            if (no % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
        static void Main()
        {
            Demo2 obj = new Demo2();
            obj.Greet("Virat");
            obj.Add(3, 4);
            obj.Add(5);
            obj.Sum(new int[] { 12, 23, 34, 45, 56 });
            int[] b = new int[3] { 23, 34, 45 };
            obj.Sum(b);
            obj.IsEven(231);
            
            obj.Add(b: 23, a: 12); //named parameters
        }
    }
}
