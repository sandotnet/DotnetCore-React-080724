using Jeanstackapi.Entities;
using Jeanstackapi.models;

namespace Jeanstackapi.Repositiries
{
    public class UserFunctions : UserInterface
    {

        private readonly MyContext context;

        public UserFunctions(MyContext context)
        {
            this.context = context;
        }

        public Profile editProfile(Profile user)
        {
            try
            {
                var existingUser = context.users.Find(user.userId);

                if (existingUser == null)
                {
                    throw new Exception("User not found");
                }

                existingUser.username = user.username;
                existingUser.email = user.email;
                existingUser.type = user.type;

                context.SaveChanges();

                return new Profile {username=existingUser.username,email=existingUser.email,type=existingUser.type,userId=existingUser.userId};
            }
            catch (Exception ex)
            {
                throw new Exception("Error editing user profile: " + ex.Message);
            }
        }

        public User login(string username, string password)
        {
            try
            {
                var user=context.users.SingleOrDefault(user=>(user.username  == username||user.email==username));
                if (user == null)
                {
                    throw new Exception("User Not found");
                }
                if(user.password!= password)
                {
                    throw new Exception("password incorrect");
                }
                return user;

            }catch (Exception ex)
            {

            throw new NotImplementedException(ex.Message);
            }
        }

        public void signUp(User user)
        {
            try
            {
                    
                context.users.Add(user);
                context.SaveChanges();

            }catch(Exception e)
            {

            throw new NotImplementedException(e.Message);
            }
        }

        public void updatePassword(string email, string old_password, string new_password)
        {
            try
            {
                var user = context.users.SingleOrDefault(p => p.email == email);
                if (user == null)
                {
                    throw new Exception("user not found");
                }
                if (user.password == old_password)
                {
                    user.password=new_password;
                    context.SaveChanges();
                }

            }catch( Exception e)
            {

            throw new NotImplementedException(e.Message);
            }
        }
    }
}
