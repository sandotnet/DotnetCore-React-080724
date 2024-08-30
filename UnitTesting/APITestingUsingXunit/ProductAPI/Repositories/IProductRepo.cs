using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAPI.Models;
namespace ProductAPI.Repositories
{
    public interface IProductRepo
    {
        List<Products> GetProducts();
        Products GetProduct(int id);
        void AddProduct(Products item);
        void UpdateProduct(Products item);
        void DeleteProduct(Products item);
    }
}
