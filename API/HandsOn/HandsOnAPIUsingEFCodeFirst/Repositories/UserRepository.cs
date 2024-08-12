using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EComContext _context;
        private IConfiguration _configuration;

<<<<<<< HEAD
        public UserRepository(EComContext context)
        {
            _context = context;
        }

        public UserRepository(EComContext context, IConfiguration configuration)
=======
       
        public UserRepository(ECommContext context, IConfiguration configuration)
>>>>>>> fa3f6e3f04414bedcc588644259a845364845a32
        {
            _context = context;
            _configuration = configuration;
        }

        //public UserRepository()
        //{
        //    _context = new ECommContext();
        //}
        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User ValidUser(string email, string password)
        {
            return _context.Users.SingleOrDefault(u=>u.Email==email && u.Password==password);
        }
    }
}
