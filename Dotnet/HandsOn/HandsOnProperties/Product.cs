using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Product
    {
        //Automatic properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } = 900;
        public double Stock { get; set; }
        static void Main()
        {
            Product product = new Product();
            product.Id = 342098;
            product.Name = "Mouse";
            product.Price = 789;
            product.Stock = 90;
        }
    }
}
