using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface ICountryRepository
    {
        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        Country GetCountry(int id);
        ICollection<Country> GetCountries();      
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);
        bool Save();
    }
}