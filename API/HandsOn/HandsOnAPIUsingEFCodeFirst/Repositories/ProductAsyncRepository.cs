using HandsOnAPIUsingEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class ProductAsyncRepository:IProductAsyncRepository
    {
        private readonly EComContext _context;

        public ProductAsyncRepository(EComContext context)
        {
            _context = context;
        }

        /*  public async Task  DeleteById(int id)
          {

              var product = await _context.Products.FindAsync(id);

                  _context.Products.Remove(product);
                  await _context.SaveChangesAsync();


          }*/

        public async Task DeleteById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                // Handle the case when the product is not found (e.g., log an error or throw an exception)
                throw new InvalidOperationException($"Product with ID {id} not found.");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product>GetById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p=>p.ProductId==id);
        }

        public async  Task  Update(Product product)
        {
           
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            
        }
    }
}
