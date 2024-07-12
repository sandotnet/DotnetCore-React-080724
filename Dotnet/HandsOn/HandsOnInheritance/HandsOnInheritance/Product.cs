using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString() //redifining the Object Class ToString()
        {
            return $"ID:{Id} Name:{Name} Price:{Price}";
        }
        static void Main()
        {
            Product p = new Product() { Id = 10, Name = "Choclate", Price = 40 };
            Console.WriteLine(p);
            Object ob = new Product() { Id = 20, Name = "Bottle", Price = 50 };
            Console.WriteLine(ob);
        }
    }
}
