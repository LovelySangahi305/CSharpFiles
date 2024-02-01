using Microsoft.EntityFrameworkCore;

namespace WebAppl1_day21.Models
{
    public class FilmDBContext : DbContext
    {
        public FilmDBContext(DbContextOptions<FilmDBContext> options) : base(options)
        { 
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
    }
}
