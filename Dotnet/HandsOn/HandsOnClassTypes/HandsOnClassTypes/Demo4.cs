using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //1.abstract classes are declared using abstract keyword.
    //2. abstract classes are inhertited but not instantiated.
    abstract class Shape
    {
        public abstract void Area(); //abstract methods
        public void Details() //not abstract method
        {
            Console.WriteLine("I am 2d Shape");
        }
    }
    class Circle:Shape
    {
        public double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override void Area()
        {
            double result = (Math.PI * r * r);
            Console.WriteLine("Area of Circle: " + result);
        }
    }
    class Rectangle:Shape
    {
        public int l, w;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }

        public override void Area()
        {
            int result = l * w;
            Console.WriteLine("Area of Rectangle: " + result);
        }
    }
    class Demo4
    {
        static void Main()
        {
            Shape s = null;
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangel");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    s = new Circle(12.3);
                    s.Area();
                    s.Details();
                    break;
                case 2:
                    s = new Rectangle(2, 3);
                    s.Area();
                    s.Details();
                    break;
            }
        }
    }
}
