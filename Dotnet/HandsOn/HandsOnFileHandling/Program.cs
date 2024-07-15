using System.IO;
namespace HandsOnFileHandling
{
    class FileDemo
    {
        public static void Create(string path)
        {
            File.Create(path); //create a new file in the given path
        }
        public  static void Read(string path)
        {
            string content=File.ReadAllText(path);
            Console.WriteLine(content);
        }
        public static void Write(string path)
        {
            string content = "All glitters are not gold";
            //File.WriteAllText(path, content); //existing content is override with new content
           File.AppendAllText(path, Environment.NewLine+content); //add contents to the existing content
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // FileDemo.Create("D:/sample.txt");
                //Console.WriteLine("Enter File Path");
                //string path = Console.ReadLine();
                //FileDemo.Read(path);
                FileDemo.Write("D:/sample.txt");
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
