namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 34, 23, 12, 24, 56, 66, 67, 78, 89, 80 }; //data source
            //fetch even values from array
            var result = from k in n
                         where k % 2 == 0
                         select k;
            result = n.Where(k => k % 2 == 0);
            //fetch even values >50
            IEnumerable<int> r = from k in n
                                 where k % 2 == 0 && k > 50
                                 select k;
            r=n.Where(k=>k%2==0 && k > 50);
             result = from k in n
                         where k % 2 != 0
                         orderby k
                         select k;
            result=n.Where(k=>k%2!=0).OrderBy(k=>k);
            //result = from k in n
            //         where k % 2 != 0
            //         orderby k descending
            //         select k;
            result=n.Where(k=>k%2==0).OrderByDescending(k=>k);

            //deferred execution
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
