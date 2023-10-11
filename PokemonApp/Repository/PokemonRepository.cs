using PokemonApp.Data;
using PokemonApp.Models;

namespace PokemonApp.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(pokemon => pokemon.Id).ToList();
        }
    }
}
