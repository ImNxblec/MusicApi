using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Data;
using MusicApi.DTO;
using MusicApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApiDbContext dbContext;

        public SongsController(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return dbContext.Songs;
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return dbContext.Songs.Find(id);
        }

        // POST api/<SongsController>
        [HttpPost]
        public ActionResult Post([FromBody] SongDto newSong)
        {
            var song = new Song
            {
                title = newSong.title,
                Language = newSong.Language
            };
            dbContext.Songs.Add(song);
            dbContext.SaveChanges();

            return Ok();
        }


        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var songToDelete = dbContext.Songs.Find(id);
            if (songToDelete != null) 
            {
                dbContext.Songs.Remove(songToDelete);
                dbContext.SaveChanges();
            }
            //var songToDelete = dbContext.Songs.Find(id);
            //dbContext.Songs.Remove(dbContext.Songs.Find(id));
            //dbContext.SaveChanges();
        }
    }
}
