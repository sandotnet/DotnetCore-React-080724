using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    class Rectangle
    {
        public int l, w;
        public Rectangle()
        {
            l = 10;
            w = 20;
        }
        public Rectangle(int l,int w)
        {
            this.l = l;
            this.w = w;
        }
        public Rectangle(Rectangle rectangle) //copy constructor
        {
            l = rectangle.l;
            w = rectangle.w;
        }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle: "+(l * w));
        }
    }
    class Demo2
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle(12, 23);
            Rectangle r2 = new Rectangle(34, 45);
            Rectangle r3 = new Rectangle(r1); //r1 values are copy to r3 //deep copy
            r1.l = 10;
            Rectangle r4 = r2; //shallow copy
            r2.l = 10;
            r.Area();
            r1.Area();
            r2.Area();
            r3.Area();
            r4.Area();

        }
    }
}
