using HandsOnAPIUsingModels.Models;

namespace HandsOnAPIUsingModels.Repositories
{
    public class MovieRepository:IMovieRepository
    {
        //data source
        private readonly List<Movie> _movies = new List<Movie>()
        {
            new Movie(){Id=33,Title="Kalki",Actor="Prabhas",Director="Nag Ashwin",ReleaseDate=new DateTime(2024,5,21)},
             new Movie(){Id=35,Title="Jawan",Actor="Sharukh",Director="Atli",ReleaseDate=new DateTime(2023,11,11)},
        };

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public List<Movie> GetAll()
        {
            return _movies;
        }

        public Movie GetByById(int id)
        {
            return _movies.SingleOrDefault(m => m.Id == id);
        }

        public Movie GetByTitle(string title)
        {
            return _movies.SingleOrDefault(m => m.Title == title);
        }
    }
}
