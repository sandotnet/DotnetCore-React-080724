using Microsoft.AspNetCore.Mvc;

namespace HandsOnModels.Models
{
    public class ProductRepository
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=34,Name="Bottle",Price=300,Description="DDD"},
            new Product(){Id=32,Name="Mouse",Price=1300,Description="Laptop Item"},
            new Product(){Id=12,Name="Keyboard",Price=3100,Description="Laptop Item"},
            new Product(){Id=56,Name="Box",Price=300,Description="Kitchen Item"},
        };
       public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProduct(int id)
        {
            return products.Single(p => p.Id == id);
        }
       
        public void Add(Product product)
        {
            products.Add(product); //adds product to the list
        }
    }
}
