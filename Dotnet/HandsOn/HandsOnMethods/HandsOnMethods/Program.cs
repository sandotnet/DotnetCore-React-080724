using System;

namespace HandsOnMethods
{
    class Sample
    {
         int a, b;
        public void Set()
        {
            a = 10;
            b = 20;
        }
        public void Accept(int i,int j)
        {
            a = i;
            b = j;
        }
        public void Show()
        {
            Console.WriteLine($"a:{a} b:{b}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sample s1 = new Sample();
            s1.Set(); //invoking method
            s1.Show();
            Sample s2 = new Sample();
            s2.Accept(23, 34);
            s2.Show();
            s2.Accept(45, 56);
            s2.Show();
        }
    }
}
