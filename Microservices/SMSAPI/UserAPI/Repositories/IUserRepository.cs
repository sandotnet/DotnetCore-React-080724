using UserAPI.Models;

namespace UserAPI.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Validate(string  username,string password);
        void EditUser(User user);

    }
}
