using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo3
    {
        public static int Sqaure(int no)
        {
            int result = no * no;
           return result;

        }
        public bool IsEven(int no)
        {
            return no % 2 == 0 ? true : false;
        }
        public string Greet(string name)
        {
            return $"Hello {name} ";
        }
        public string [] GetFlowers()
        {
            string[] flowers = { "Rose", "Lilly", "Jasmine" };
            return flowers;
        }
        static void Main()
        {
            
            int result=Sqaure(12);
            Console.WriteLine(result);
            result = Demo3.Sqaure(23);
            Demo3 obj = new Demo3();
            Console.WriteLine(obj.IsEven(12));
            Console.WriteLine(obj.Greet("Sachin"));
            string[] f = obj.GetFlowers();
            foreach (var k in f)
                Console.WriteLine(f);
            foreach(var i in obj.GetFlowers())
            {
                Console.WriteLine(i);
            }
        }
    }
}
