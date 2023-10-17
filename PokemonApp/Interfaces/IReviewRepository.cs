using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IReviewRepository
    {
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        Review GetReview(int reviewId);
        ICollection<Review> GetReviews();
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        bool Save();
    }
}