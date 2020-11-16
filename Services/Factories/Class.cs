using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelApp.ClientApp.API.ResponseBodies;
using AngelApp.Models;

namespace AngelApp.Services.Factories
{

    interface IPokemonFactory
    {
        List<PokemonResponse> ListOfPokemonToListOfPokemonResponses(List<Pokemon> pokemons);
        PokemonResponse PokemonToPokemonResponse(Pokemon pokemons);
    }

    class PokemonFactory : IPokemonFactory
    {
        public List<PokemonResponse> ListOfPokemonToListOfPokemonResponses(List<Pokemon> pokemons)
        {
            var pokemonResponses = new List<PokemonResponse>();
            foreach (var pokemon in pokemons)
            {
                pokemonResponses.Add(PokemonToPokemonResponse(pokemon));
            }

            return pokemonResponses;
        }

        public PokemonResponse PokemonToPokemonResponse(Pokemon pokemon)
        {
            return new PokemonResponse()
            {
                Id = pokemon.pokedex_number,
                Name = pokemon.name,
                Type1 = pokemon.type1,
                Type2 = pokemon.type2
            };
        }
    }
}
