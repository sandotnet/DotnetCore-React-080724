namespace HandsOnClassesAndOjects
{
    class Customer
    {
        //class-variables
        public int id;
        public string name;
        public string address;
        public void Display() //display the customer details
        {
            Console.WriteLine($"ID:{id} Name:{name} Address:{address}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create customer object(instantiate customer object)
            Customer c1= new Customer();
            c1.id = 1;
            c1.name = "Rohith";
            c1.address = "Hyderabad";
            c1.Display();
            //object initializer
            Customer c2 = new Customer() { id = 2, name = "Rajan", address = "Cheanni" };
            c2.Display();
            Customer c3 = new Customer();
            c3.Display();
            Console.WriteLine();
            //Customer Array
            Customer[] customers = new Customer[4];
            customers[0] = new Customer() { id = 5, name = "Hari", address = "Banglore" };
            customers[1] = new Customer() { id = 6, name = "Kiran", address = "Chennai" };
            customers[2] = new Customer() { id = 7, name = "Rani", address = "Banglore" };
            customers[3] = c2; //shallow copy
            c2.address = "Chennai,OMR";
            foreach (var customer in customers)
            {
                customer.Display();
            }

        }
    }
}
