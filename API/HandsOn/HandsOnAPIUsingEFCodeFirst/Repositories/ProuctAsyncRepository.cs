using HandsOnAPIUsingEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class ProuctAsyncRepository : IProuctAsyncRepository
    {
        private readonly ECommContext _context;

        public ProuctAsyncRepository(ECommContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAll()
        {
            return  await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p => p.ProductId == id);
        }
    }
}
