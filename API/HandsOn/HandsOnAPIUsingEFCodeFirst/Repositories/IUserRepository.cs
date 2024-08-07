using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface IUserRepository
    {
        void Register(User user); //Add User
        User ValidUser(string email, string password);
    }
}
