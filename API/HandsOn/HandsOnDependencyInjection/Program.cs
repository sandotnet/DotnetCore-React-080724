namespace HandsOnDependencyInjection
{
    class Car
    {
        public string Model;
        public string Make;

        public Car(string model, string make)
        {
            Model = model;
            Make = make;
        }
    }
    class Garage
    {
        private Car car;
        public Garage(Car car) //Create the car object with out passing model and make
                               //values(dependencies)
        {
            this.car = car;
        }
        //public Garage()
        //{
        //    car = new Car();
        //}
        public void Display()
        {
            Console.WriteLine($"Car Details:Model:{car.Model} Maker:{car.Make}");
        }
    }
    class Test
    {
        public Garage garage;
        //public Test()
        //{
        //    garage = new Garage();
        //}
        public Test(Garage garage)
        {
            this.garage = garage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Garage obj = new Garage(new Car("i10", "Hundai"));
        }
    }
}
