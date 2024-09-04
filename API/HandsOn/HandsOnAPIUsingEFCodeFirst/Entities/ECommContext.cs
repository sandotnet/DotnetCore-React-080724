using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class ECommContext:DbContext
    {
        private IConfiguration _configuration;

        public ECommContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        //Entity Set
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //Configure Connnectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EComm;Integrated Security=True;Trust Server Certificate=True\r\n");
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ECommConnection"));
        }
    }
}
