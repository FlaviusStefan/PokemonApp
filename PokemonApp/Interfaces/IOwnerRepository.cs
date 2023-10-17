using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IOwnerRepository
    {
        bool CreateOwner(Owner owner);
        bool UpdateOwner(Owner owner);
        bool DeleteOwner(Owner owner);
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwners();
        ICollection<Owner>GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int OwnerId);   
        bool Save();
    }
}