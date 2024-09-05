using Microsoft.EntityFrameworkCore;

namespace Jeanstackapi.Entities
{
    public class MyContext:DbContext
    {
        private readonly IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        //add entities
        public DbSet<Product> Products { get; set; }
        public DbSet<User> users { get; set; }
       public DbSet<Cart> carts { get; set; }
        public DbSet<Order> orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = configuration.GetConnectionString("MysqlConnection");
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }
       
    }
}
