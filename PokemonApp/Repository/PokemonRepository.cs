using PokemonApp.Data;
using PokemonApp.Interfaces;
using PokemonApp.Models;

namespace PokemonApp.Repository
{
    public class PokemonRepository : IPokemonRepository
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

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(pokemon => pokemon.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(pokemon => pokemon.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokemonId)
        {
            var review = _context.Reviews.Where(pokemon => pokemon.Id == pokemonId);

            if (review.Count() <= 0)
                return 0;

            return ((decimal)review.Sum(review => review.Rating)) / review.Count();
        }

        public bool PokemonExists(int pokemonId)
        {
            return _context.Pokemon.Any(pokemon => pokemon.Id == pokemonId);
        }

        
    }
}
