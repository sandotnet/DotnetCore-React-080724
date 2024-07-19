using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNewFeatures
{
    //Nullable types are value types can accpet null value and default value is set as null
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; } //Nullable type
        public int? Stock { get; set; } //Nullable type
        public override string ToString()
        {
            return $"ID:{Id} Name:{Name} Price:{Price} Stock:{Stock}";
        }
        static void Main()
        {
            dynamic i1 = null;
            int k = 0; //value type
            int? i = null; //nullable type
            Product product = new Product();
            product.Id = 1;
            product.Name = "Mouse";
            Console.WriteLine(i1);
            Console.WriteLine(product.ToString());

        }
    }
}
