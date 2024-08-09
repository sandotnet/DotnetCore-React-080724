using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface IProuctAsyncRepository
    {
         Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
    }
}
