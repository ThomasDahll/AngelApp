using System.Collections.Generic;
using System.Threading.Tasks;
using AngelApp.Models;

namespace AngelApp.Repository
{
    public interface IPokemonsRepository
    {
        Task<List<Pokemon>> GetPokemonsAsync();
        Task<Pokemon> GetPokemonAsync(int id);

    }
}