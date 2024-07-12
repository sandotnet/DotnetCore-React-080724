using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    internal class ReadWrite
    {
        //Read content from the file
        public static void Read(string path)
        {

            //using block automatically dispose the object once code get execute
            using (StreamReader sr = new StreamReader(path))
            {
                string content=sr.ReadToEnd(); //reads all lines in the given file
                Console.WriteLine(content); 
            }
        }
        public static void Write(string path)
        {
            using(StreamWriter sw=new StreamWriter(path,true))
            {
                string content = "GoodEvening Students";
                sw.WriteLine(content);
            }
        }
        static void Main()
        {
            string path=Console.ReadLine();
            //Read(path);
            Write(path);
        }
    }
}
