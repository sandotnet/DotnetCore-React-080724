using MyLibrary;
namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculate obj=new Calculate();
            Console.WriteLine("Addition: "+obj.Add(33443, 34432));
            Console.WriteLine("Division: "+obj.Div(33232, 2332));
            double dollers = Currency.RTD(100000);
            Console.WriteLine("Dollers: $" + dollers);
            Console.WriteLine("Dollers:${0:F2}",dollers);

        }
    }
}
