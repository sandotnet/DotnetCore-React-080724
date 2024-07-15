using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class XX<T>
    {
        public T a;
        public T M(T a) //Generic method
        {
            return a;
        }
    }
    class YY:XX<int>
    {

    }
    class ZZ<T>:XX<T>
    {

    }
    internal class Demo9
    {
        static void Main()
        {
            YY obj = new YY();
            obj.a = 10;
            ZZ<int> ob= new ZZ<int>();
            ob.a = 10;
            Console.WriteLine(ob.M(10));
            ZZ<string> sb= new ZZ<string>();
            sb.a = "David";
            Console.WriteLine(sb.M(sb.a));
        }
    }
}
