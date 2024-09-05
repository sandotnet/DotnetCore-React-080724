using Jeanstackapi.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Jeanstackapi.Repositiries
{
    public class ProductFunctions : ProductInterface
    {
        private readonly MyContext context;

        public ProductFunctions(MyContext context)
        {
            this.context = context;
        }

      
        public void AddProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();

            }catch (Exception ex)
            {
            throw new NotImplementedException(ex.Message);

            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var products= context.Products.ToList();
                return products;
            }catch (Exception ex)
            {

            throw new NotImplementedException(ex.Message);
            }
        }

        public Product GetProductById(int id)
        {
            try
            {
                var product = context.Products.Find(id);
                if (product == null)
                {
                    throw new NotImplementedException();
                }
                return product;
            }catch(Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public void RemoveProductById(int id)
        {
            try
            {
                var dproduct = context.Products.Find(id);
                context.Products.Remove(dproduct);
                 context.SaveChanges();
            }catch(Exception ex)

            {
            throw new NotImplementedException(ex.Message);
            }
        }

        public void UpdateProductByID(Product product)
        {
            try
            {
                context.Products.Update(product);
                context.SaveChanges();



            }catch(Exception ex)
            {

            throw new NotImplementedException(ex.Message);
            }
        }
    }
}
