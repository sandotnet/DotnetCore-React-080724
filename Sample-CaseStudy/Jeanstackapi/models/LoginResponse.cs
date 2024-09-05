namespace Jeanstackapi.models
{
    public class LoginResponse
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public string type { get; set; }
    }
}
