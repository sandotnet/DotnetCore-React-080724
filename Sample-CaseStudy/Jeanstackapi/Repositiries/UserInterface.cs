using Jeanstackapi.Entities;
using Jeanstackapi.models;

namespace Jeanstackapi.Repositiries
{
    public interface UserInterface
    {
        public void signUp(User user);
        public User login(string username,string password);
        public Profile editProfile(Profile user);
        public void updatePassword(string email,string old_password,string new_password);
    }
}
