namespace HandsOnConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //casting
            int a = 100;

            byte b = (byte)a; //convert int to byte
            Console.WriteLine("b "+b);
            short s = (short)a; //convert int to short
            Console.WriteLine("s "+s);
            long l = 127;
            int k = (int)l; //convert long to int
            Console.WriteLine("k "+k);
            s= (short)l;
            b = (byte)l;
            Console.WriteLine(b);
            double d = 45.4;
            int j=(int)d;
            Console.WriteLine(j); //45
            Console.WriteLine(byte.MaxValue);

            //implicit conversion
            int n = 456;
            double d1 = n;
            long l1 = n;
        }
    }
}
