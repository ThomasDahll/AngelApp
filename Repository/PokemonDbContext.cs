using AngelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AngelApp.Repository
{
    public class PokemonDbContext : DbContext
    {
        public DbSet<Pokemon> pokemon { get; set; }

        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options) { }
    }
}
