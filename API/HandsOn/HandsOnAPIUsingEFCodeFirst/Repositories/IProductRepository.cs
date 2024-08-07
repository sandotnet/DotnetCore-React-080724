using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetProduct(int Id);
        List<Product> GetAll();
        void Delete(int Id);
        void Update(Product product);

    }
}
