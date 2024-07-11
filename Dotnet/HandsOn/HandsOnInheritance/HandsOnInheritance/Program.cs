using System;

namespace HandsOnInheritance
{
    class A //base class
    {
        public int i;
        public int j;
        public void F()
        {
            Console.WriteLine("I am F() of Class A");
        }
    }
    class B : A //B is derive class
    {
        public int k;
        public void Show()
        {
            F(); //invoking class A function
            Console.WriteLine("i:{0} j:{1} k:{2}", i, j, k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            //obj can access all the public members of Class A and Class B
            obj.i = 10;
            obj.j = 20;
            obj.F();
            obj.k = 30;
            obj.Show();
            A obj2 = new A(); //access only members of class A
            obj2.i = 10;
            obj2.j = 20;
            obj2.F();
            A obj3 = new B(); //object of A and instance B
            //access members of A and over ride members of B
            obj3.i = 20;
            obj.j = 45;
            obj.F();
        }
    }
}
