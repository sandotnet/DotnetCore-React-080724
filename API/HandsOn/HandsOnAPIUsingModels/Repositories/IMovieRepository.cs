using HandsOnAPIUsingModels.Models;

namespace HandsOnAPIUsingModels.Repositories
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        Movie GetByById(int id);
        Movie GetByTitle(string title);
        List<Movie> GetAll();
    }
}
