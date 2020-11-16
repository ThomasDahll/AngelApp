using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngelApp.ClientApp.API.ResponseBodies;
using AngelApp.Models;
using AngelApp.Repository;
using AngelApp.Services.Factories;

namespace AngelApp.Services
{
    public interface IPokemonService
    {
        Task<List<PokemonResponse>> GetListOfAllPokemons();
        Task<PokemonResponse> GetPokemonResponseById(int id);

    }

    class PokemonService : IPokemonService
    {
        private readonly IPokemonsRepository _repository;
        private readonly IPokemonFactory _factory;

        public PokemonService(IPokemonsRepository repository, IPokemonFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task<List<PokemonResponse>> GetListOfAllPokemons()
        {
            var pokemons = await _repository.GetPokemonsAsync();
            return _factory.ListOfPokemonToListOfPokemonResponses(pokemons);
        }

        public async Task<PokemonResponse> GetPokemonResponseById(int id)
        {
            var pokemon = await _repository.GetPokemonAsync(id);
            return _factory.PokemonToPokemonResponse(pokemon);
        }
    }
}
