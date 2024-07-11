using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double Area
        {
            get { return Math.PI * r * r; }
        }
        static void Main()
        {
            Circle c = new Circle(12);
            Console.WriteLine(c.Area);
        }
    }
}
