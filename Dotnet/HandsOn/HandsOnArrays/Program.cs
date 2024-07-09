namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array declartion
            int[] a = new int[5]; //hold 5 values
            //assign values
            a[0] = 34;
            a[1] = 90;
            a[2] = 78;
            a[4] = 56;
            a[3] = 66;
            //access value from array
            Console.WriteLine(a[2]); //78
            //Console.WriteLine(a[10]); //run time error
            //read all values from array
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
