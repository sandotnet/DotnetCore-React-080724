using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAPI.Models;
using ProductAPI.Repositories;
namespace ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private  IProductRepo repo;
        public ProductService(IProductRepo _repo)
        {
            repo = _repo;
        }
        public void AddProduct(Products item)
        {
            repo.AddProduct(item);
        }

        public void DeleteProduct(Products item)
        {
            repo.DeleteProduct(item);
        }

        public Products GetProduct(int id)
        {
            return repo.GetProduct(id);
        }

        public List<Products> GetProducts()
        {
            return repo.GetProducts();
        }

        public void UpdateProduct(Products item)
        {
             repo.UpdateProduct(item);
        }
    }
}
