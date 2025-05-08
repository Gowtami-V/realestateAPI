using Microsoft.AspNetCore.Mvc;

namespace RealEstateAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RealEstateController : ControllerBase
    {
        /// <summary>
        /// Retrieves a list of all properties.
        /// </summary>
        /// <returns>List of properties</returns>
        [HttpGet]
        public IActionResult GetProperties()
        {
            return Ok(new[] { "Property 1", "Property 2", "Property 3" });
        }

        /// <summary>
        /// Retrieves a specific property by ID.
        /// </summary>
        /// <param name="id">Property ID</param>
        /// <returns>Property details</returns>
        [HttpGet("{id}")]
        public IActionResult GetPropertyById(int id)
        {
            return Ok($"Property {id}");
        }
    }
}
