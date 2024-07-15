using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;
using System.IO;
namespace HandsOnSerialization
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Tulips");
            ar.Add("Rose");
            ar.Add("Lilly");
            ar.Add("Daffodill");
            XmlSerializer obj = new XmlSerializer(typeof(ArrayList));
            obj.Serialize(new StreamWriter("D:/flowrer.xml"), ar);
        }
    }
}
