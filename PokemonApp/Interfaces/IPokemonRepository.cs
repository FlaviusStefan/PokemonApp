using PokemonApp.DTOs;
using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IPokemonRepository
    {
        // parameters where <Pokemon> is included
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemon);
        Pokemon GetPokemon(int pokeId);
        Pokemon GetPokemon(string name);
        Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate);
        ICollection<Pokemon> GetPokemons();     
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId); 
        bool Save();
    }
}