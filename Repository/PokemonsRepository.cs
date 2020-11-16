using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AngelApp.Repository
{
    public class PokemonsRepository : IPokemonsRepository
    {
        private readonly PokemonDbContext _context;
        private readonly ILogger _logger;

        public PokemonsRepository(PokemonDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("PokemonsRepository");
        }

        public async Task<List<Pokemon>> GetPokemonsAsync()
        {

            return await _context.pokemon.OrderBy(p => p.pokedex_number).ToListAsync();
        }

        public async Task<Pokemon> GetPokemonAsync(int id)
        {
            return await _context.pokemon.SingleOrDefaultAsync(p => p.pokedex_number == id);
        }
    }


}
