using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
       //data source
        private readonly List<Movie> _movies=new List<Movie>()
        {
            new Movie(){Id=33,Title="Kalki",Actor="Prabhas",Director="Nag Ashwin",ReleaseDate=new DateTime(2024,5,21)},
             new Movie(){Id=35,Title="Jawan",Actor="Sharukh",Director="Atli",ReleaseDate=new DateTime(2023,11,11)},
        };
        //endpoints
        //Get All Movies
        [HttpGet,Route("GetAll")]
        public IActionResult GetMovies()
        {
            return Ok(_movies);
        }
        [HttpGet, Route("GetMovie/{id}")]
        public IActionResult GetMovie([FromRoute]int id)
        {
            try
            {
                var movie = _movies.SingleOrDefault(m => m.Id == id);
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
    }
}
