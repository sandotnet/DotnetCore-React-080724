using System;

namespace HandsOnClassTypes
{
    //1.static class can have only static members
    //2. static class can not be inherited and instantiated
    //3. static class members can access using class name
    static class Compute
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Compute.Add(12, 23);
        }
    }
}
