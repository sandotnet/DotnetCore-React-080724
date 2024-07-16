using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo4
    {
        static void Main()
        {
            List<Product> list = new List<Product>()
            {
                new Product {Id=1,Name="Keyboard",Price=400 },
                new Product {Id=3,Name="Pendrive",Price=800 },
                new Product {Id=4,Name="Speaker",Price=1000 },
                new Product {Id=5,Name="JouStock",Price=500 },
                new Product {Id=6,Name="Mouse Pad",Price=200 },
            };
            Product product = new Product();
            product.Id = 10;
            product.Name = "Optical Mouse";
            product.Price = 1000;
            Dictionary<int, Product> map = new Dictionary<int, Product>();
            map.Add(1, list[0]);
            map.Add(3, list[1]);
            map.Add(4, list[2]);
            map.Add(5, list[3]);
            map.Add(list[4].Id, list[4]);
            map.Add(product.Id, product);
            map.Add(12, list[3]);
            map.Add(13, new Product() { Id=13,Name="AAA",Price=20});
            Product p = map[5];
            Console.WriteLine(p);


        }
    }
}
