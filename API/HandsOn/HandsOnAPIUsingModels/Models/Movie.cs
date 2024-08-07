namespace HandsOnAPIUsingModels.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Actor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Director { get; set; }
    }
}
