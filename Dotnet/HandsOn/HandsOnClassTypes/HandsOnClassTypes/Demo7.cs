using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
   
    //Geniric class
    class Sample<T>
    {
        //generic variables
        public T a;
        public T b;
        public int c;
        public void M(T i,T j) //generic parameters
        {
            a = i;
            b = j;
            Console.WriteLine($"a={a} b={b}");
        }
    }
    class KeyPair<K, V> //generic class with two placeholders
    {
        public K i;
        public V j;
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
            Sample<double> obj4 = new Sample<double>();
            obj4.a = 12.3;
            obj4.b = 34.5;
            KeyPair<int, string> ob = new KeyPair<int, string>();
            ob.i = 10;
            ob.j = "David";

        }

    }
}
