using Microsoft.EntityFrameworkCore;
using MovieTarea.Models;
using System.Collections.Generic;

namespace MovieTarea.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }
    }
}
