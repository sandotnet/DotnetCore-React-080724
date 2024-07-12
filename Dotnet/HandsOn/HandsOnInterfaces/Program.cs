namespace HandsOnInterfaces
{
    interface Ishape
    {
        //members
        public void Area();
        public void Diameter();
    }
    class Circle:Ishape
    {
        public double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public void Area()
        {
            Console.WriteLine("Circle Area"+Math.PI*r*r);
        }
        public void Diameter()
        {
            Console.WriteLine("Circle Diameter");
        }
        public void Perimeter() //Not a interface member
        {
            Console.WriteLine("Circle Pertimeter");
        }
    }
    class Rectangle:Ishape
    {
        public void Area()
        {
            Console.WriteLine("Area of Reactagnle");
        }
        public void Diameter()
        {

            Console.WriteLine("Reactangle Diamter");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape circle = new Circle(12); //object of Interface and instance of
                                            //class access only interface members
            circle.Area();
            circle.Diameter();
           
            Ishape rectangle = new Rectangle();
            rectangle.Area();
            rectangle.Diameter();
            Circle c1 = new Circle(12.23);
            c1.Perimeter();
            c1.Diameter();
            c1.Area();
            
        }
    }
}
