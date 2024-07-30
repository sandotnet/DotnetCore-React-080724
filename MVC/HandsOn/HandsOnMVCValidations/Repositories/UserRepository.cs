
using HandsOnMVCValidations.Models;

namespace HandsOnMVCValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User(){FirstName="Karan",LastName="Chand",Email="karan@gmail.com"
                ,Password="karan@123",
            Country="India",Gender="Male",Mobile="90989090989" }
        };
        public void Register(User user)
        {
            try
            {
                users.Add(user);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public User Validate(Login login)
        {
            User user=users.SingleOrDefault(u=>u.Email==login.Username && u.Password==login.Password);
            return user;
        }
    }
}
