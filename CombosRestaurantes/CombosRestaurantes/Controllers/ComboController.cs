using CombosRestaurantes.Data;
using CombosRestaurantes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CombosRestaurantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComboController : ControllerBase
    {
        private readonly ComboDbContext dbContext;
        public ComboController(ComboDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Combo> Get()
        {
            return dbContext.Menus;
        }


        [HttpGet("{id}")]
        public Combo Get(int id)
        {
            return dbContext.Menus.Find(id);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ComoboToDelete = dbContext.Menus.Find(id);
            if (ComoboToDelete != null)
            {
                dbContext.Menus.Remove(ComoboToDelete);
                dbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
