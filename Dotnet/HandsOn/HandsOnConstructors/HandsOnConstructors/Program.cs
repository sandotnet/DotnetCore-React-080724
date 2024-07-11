using System;

namespace HandsOnConstructors
{
    class Circle
    {
        public double r;
        public static double PI;
      
        public Circle() //default constructor
        {
            Console.WriteLine("Object Initiated");
            r = 10.3;
        }
        static Circle() //static constructor
        {
            Console.WriteLine("I am Static Constructor Invoking only once..");
            PI = 3.14;
        }
        public Circle(double radius) //parameterized constructor
        {
            Console.WriteLine("Object Initiated");
            r = radius;
        }
        public void Area()
        {
            double area = PI * r * r;
            Console.WriteLine($"Area of Circle with Radius {r} is {area}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Area();
            Circle c2 = new Circle();
            c2.Area();
            Circle c3 = new Circle(12.3);
            Circle c4 = new Circle(34.45);
            c3.Area();
            c4.Area();



        }
    }
}
