using Jeanstackapi.Entities;
namespace Jeanstackapi.Entities
{
    public interface ProductInterface
    {
        public void AddProduct(Product product);
        public void RemoveProductById(int id);
        public Product GetProductById(int id);

        public List<Product> GetAllProducts();

        public void UpdateProductByID(Product product);






    }
}
