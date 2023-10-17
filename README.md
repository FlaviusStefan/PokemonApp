# PokemonApp

Welcome to the Pokemon App API ! This API is designed to provide a set of endpoints for managing various aspects of a Pokemon-themed application, including categories, countries, owners, Pokemon, reviews, and reviewers. With this API, you can create, update, delete, and retrieve data related to these classes.

##################################################

FEATURES

The API provides the following classes, each with its own set of features:

<br>

Category: Create, update, delete, and get category information.

Country: Create, update, delete, and get country information.

Owner: Create, update, delete, and get owner profiles.

Pokemon: Create, update, delete, and get Pokemon details.

Review: Create, update, delete, and get reviews for Pokemon.

Reviewer: Create, update, delete, and get reviewer profiles.

<br>

##################################################

ENDPOINTS

The API provides the following endpoints for each class:

<br>

1) Category

POST: /api/Category

GET: /api/Category

PUT: /api/Category/{categoryId}

DELETE: /api/Category/{categoryId}

GET: /api/Category/{categoryId}

GET: /api/Category/pokemon/{categoryId}

<br>

2) Country

POST: /api/Country

GET: /api/Country

PUT: /api/Country/{countryId}

DELETE: /api/Country/{countryId}

GET: /api/Country/{countryId}

GET: /owner/{ownerId}

<br>

3) Owner

POST: /api/Owner

GET: /api/Owner

PUT: /api/Owner/{ownerId}

DELETE: /api/Owner/{ownerId}

GET: /api/Owner/{ownerId}

GET: /api/Owner/{ownerId}/pokemon

<br>

4) Pokemon

POST: /api/Pokemon

GET: /api/Pokemon

PUT: /api/Pokemon/{pokemonId}

DELETE: /api/Pokemon/{pokemonId}

GET: /api/Pokemon/{pokemonId}

GET: /api/Pokemon/{pokemonId}/rating

<br>

5) Review

POST: /api/Review

GET: /api/Review

PUT: /api/Review/{reviewId}

DELETE: /api/Review/{reviewId}

GET: /api/Review/{reviewId}

DELETE: /DeleteReviewsByReviewer/{reviewerId}

GET: /api/Review/pokemon/{pokeId}

<br>

6) Reviewer

POST: /api/Reviewer

GET: /api/Reviewer

PUT: /api/Reviewer/{reviewerId}

DELETE: /api/Reviewer/{reviewerId}

GET: /api/Reviewer/{reviewerId}

GET: /api/Reviewer/{reviewerId}/reviews






