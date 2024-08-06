using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class ECommContext:DbContext
    {
        //Entity Set
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        //Configure Connnectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EComm;Integrated Security=True;Trust Server Certificate=True\r\n");
        }
    }
}
