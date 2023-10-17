using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface ICategoryRepository
    {
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        Category GetCategory(int id);
        ICollection<Category> GetCategories();
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);   
        bool Save();
    }
}