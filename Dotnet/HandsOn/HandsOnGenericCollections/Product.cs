using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"ID:{Id} Name:{Name} Price:{Price}";
        }
    }
    class List_Demo1
    {
        static void Main()
        {
            Product product = new Product();
            product.Id = 10;
            product.Name = "Optical Mouse";
            product.Price = 1000;
            List<Product> list = new List<Product>()
            {
                new Product {Id=1,Name="Keyboard",Price=400 },
                new Product {Id=3,Name="Pendrive",Price=800 },
                new Product {Id=4,Name="Speaker",Price=1000 },
                new Product {Id=5,Name="JouStock",Price=500 },
                new Product {Id=6,Name="Mouse Pad",Price=200 },
            };
            list.Add(new Product {Id=2,Name="Mouse",Price=100 });
            list.Add(product);
            Product p1 = list[3]; //to access the specific item from the list
            Console.WriteLine(p1.ToString());
            list.Remove(p1); //remove item
            foreach(var item in  list)
            {
                Console.WriteLine(item.ToString());
            }
            list.Clear(); //clear all items
        }
    }
}
