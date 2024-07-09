using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConversions
{
    internal class Demo1
    {
        static void Main()
        {
            string age = "34";
            string weight = "67.3";
            //convert string value to value datatypes is called Parsing
            int k = int.Parse(age); //convert string to int
            byte b = byte.Parse(age);
            short s = short.Parse(age);
            long l = long.Parse(age);
            double d=double.Parse(weight);
            float f = float.Parse(weight); //string to float
            decimal c = decimal.Parse(weight); //string to decimal
            string IsUser = "true";
            bool result = bool.Parse(IsUser); //string to bool
            string gender = "M";
            char g=char.Parse(gender); //convert string to char
            Console.WriteLine(age);
            string s2 = "abc";
            int n=int.Parse(s2);

            
        }
    }
}
