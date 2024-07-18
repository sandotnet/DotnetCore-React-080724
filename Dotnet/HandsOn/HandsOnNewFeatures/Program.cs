namespace HandsOnNewFeatures
{
    class Student
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            int n = 45;
            Console.WriteLine(n.Sqaure());
            string s = "David";
            Console.WriteLine(s.Reverse());
            Student obj = null;
           
          if(obj.IsNotNull()==false)
            {
                Console.WriteLine("Invalid User");
            }
            string s1 = "Abc";
            string s2 = "Abc";
            if (s1.IsEqual(s2))
            {
                Console.WriteLine("Equal");
            } else { Console.WriteLine("Not Equal"); };

        }
    }
}
