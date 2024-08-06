using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
       private readonly IMovieRepository _movieRepository;
        public MovieController()
        {
            _movieRepository = new MovieRepository();
        }
        //endpoints
        //Get All Movies
        [HttpGet,Route("GetAll")]
        public IActionResult GetMovies()
        {
            var movies = _movieRepository.GetAll();
            return Ok(movies);
        }
        [HttpGet, Route("GetMovie/{id}")]
        public IActionResult GetMovie([FromRoute]int id)
        {
            try
            {
                var movie = _movieRepository.GetByById(id);
                if (movie != null)
                    return Ok(movie);
                else
                    return NotFound("Invalid Id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
        [HttpGet, Route("GetMovieByTitle")]
        public IActionResult GetMovieByTitle([FromQuery]string title)
        {
            try
            {
                var movie = _movieRepository.GetByTitle(title);
                if (movie != null)
                    return StatusCode(200, movie);
                else
                    return StatusCode(404,"Invalid Id");
            }
            catch (Exception ex)
            {

                return StatusCode(500,ex.Message);

            }
        }
    }
}
