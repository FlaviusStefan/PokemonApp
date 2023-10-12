﻿using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int pokeId);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId); 

        // parameters where <Pokemon> is included
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);


    }
}
