using HandsOnAPIUsingExceptionHandling.CustomExceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            // Simulate a situation where a resource is not found
            try
            {
                throw new NotFoundException("The requested resource was not found.");
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        [HttpGet("invalid")]
        public ActionResult GetInvalid()
        {
            // Simulate a validation error
            try
            {
                throw new ValidationException("Validation failed for the request.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized()
        {
            try
            {
                // Simulate unauthorized access
                throw new UnauthorizedException("You do not have permission to access this resource.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("internal-error")]
        public ActionResult GetInternalError()
        {
            try
            {
                // Simulate an internal server error
                throw new InternalServerErrorException("An unexpected error occurred.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
