﻿using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);

        ICollection<Reviewer> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);

    }
}
