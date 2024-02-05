using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTarea.Data;
using MovieTarea.DTO;
using MovieTarea.Models;

namespace MovieTarea.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesDbContext dbContext;
        public MoviesController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return dbContext.Movies;
        }

    }
}
