using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface IProuctAsyncRepository
    {
         Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task Update(Product product);
        Task DeleteById(int id);
        Task Add(Product product);

    }
}
