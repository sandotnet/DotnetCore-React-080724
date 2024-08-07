namespace HandsOnAPIUsingEFCodeFirst.Entities
{
    public class User
    {
       //scalar properties
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
    }
}
