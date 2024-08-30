using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductDBContext context;
        public ProductRepo(ProductDBContext _context)
        {
            context = _context;
        }
        public void AddProduct(Products item)
        {
            context.Products.Add(item);
            context.SaveChanges();
        }

        public void DeleteProduct(Products item)
        {
            context.Products.Remove(item);
            context.SaveChanges();
        }

        public Products GetProduct(int id)
        {
            return context.Products.Find(id);
        }

        public List<Products> GetProducts()
        {
            return context.Products.ToList();
        }

        public void UpdateProduct(Products item)
        {
            context.Products.Update(item);
            context.SaveChanges();
        }

       
    }
}
