using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelApp.ClientApp.API.ResponseBodies;
using AngelApp.Models;
using AngelApp.Repository;
using AngelApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngelApp.Controllers
{

  

    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _service;
//        private readonly IPokemonsRepository _pokemonsRepository;
        private readonly ILogger _logger;

        public PokemonController(ILoggerFactory loggerFactory, IPokemonService service)
        {
            _logger = loggerFactory.CreateLogger(nameof(PokemonController));
            _service = service;
        }

        // GET api/pokemon
        [HttpGet]
        [ProducesResponseType(typeof(List<PokemonResponse>), 200)]
        public async Task<ActionResult> Pokemons()
        {
            try
            {
              var pokemons = await _service.GetListOfAllPokemons();
                return Ok(pokemons);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
            }

            return NotFound("Itte non pokemons på gang ass");
        }
    }
}
