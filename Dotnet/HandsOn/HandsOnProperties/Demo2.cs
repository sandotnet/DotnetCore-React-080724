using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Demo2
    {
        private int[] no = new int[5];
        //Indexer
        public int this[int i] //here i as index of an array
        {
            get {
                if (i < no.Length)
                {
                    return no[i];
                }
                else
                {
                    return 0;
                }

            }
            set {
                //set values to array
                if (i < no.Length)
                {
                    no[i] = value;
                }
            }
        }
    }
    class Test_Demo2
    {
        static void Main()
        {
            Demo2 demo = new Demo2();
            demo[0] = 10; //indexers set accessor invokes
            demo[1] = 20;
            demo[2] = 30;
            demo[3] = 40;
            demo[4] = 50;
            demo[10] = 60;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(demo[i]);
            }
            
        }
    }
}
