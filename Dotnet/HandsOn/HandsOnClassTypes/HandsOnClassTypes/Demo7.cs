using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class KeyPair<K,V>
    {
        public K i;
        public V j;
    }
    //Geniric class
    class Sample<T>
    {
        public T a;
        public T b;
        public int c;
        public void M(T i,T j)
        {
            a = i;
            b = j;
            Console.WriteLine($"a={a} b={b}");
        }
    }
    class Demo7
    {
        static void Main()
        {
            Sample<int> obj = new Sample<int>();
            obj.a = 10;
            obj.b = 20;
            obj.M(12, 23);
            Sample<string> obj2 = new Sample<string>();
            obj2.a = "David";
            obj2.b = "Raj";
            obj2.M("TIna", "Jo");
            Sample<char> obj3 = new Sample<char>();
            KeyPair<int, string> ob = new KeyPair<int, string>();
            ob.i = 10;
            ob.j = "David";

        }

    }
}
