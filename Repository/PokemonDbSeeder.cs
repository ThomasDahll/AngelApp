using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AngelApp.Repository
{
    public class PokemonDbSeeder
    {
        private readonly ILogger _logger;

        public PokemonDbSeeder(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("PokemonDbSeederLogger");
        }
        /*
        public async Task SeedAsync(IServiceProvider serviceProvider)
        {
            //Based on EF team's example at https://github.com/aspnet/MusicStore/blob/dev/samples/MusicStore/Models/SampleData.cs
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var pokemonsDb = serviceScope.ServiceProvider.GetService<PokemonDbContext>();
                if (await pokemonsDb.Database.EnsureCreatedAsync())
                {
                    if (!await pokemonsDb.Pokemons.AnyAsync())
                    {
                        await InsertPokemonsSampleData(pokemonsDb);
                    }
                }
            }
        }

        /*
        public async Task InsertPokemonsSampleData(PokemonDbContext db)
        {

            var pokemons = GetPokemons();
            db.Pokemons.AddRange(pokemons);
            try
            {
                int numAffected = await db.SaveChangesAsync();
                _logger.LogInformation(@"Saved {numAffected} states");
            }
            catch (Exception exp)
            {
                _logger.LogError($"Error in {nameof(PokemonDbSeeder)}: " + exp.Message);
                throw;
            }
        }

        private List<pokemon> GetPokemons()
        {
            var states = new List<pokemon>
            {
                new pokemon { Name = "Alabama", Type1 = "Fire", Type2 = ""},
                new pokemon { Name = "Danny", Type1 = "Fire", Type2 = ""},
                new pokemon { Name = "Squirt", Type1 = "Fire", Type2 = ""},
            };

            return states;
        }*/
    }


}

