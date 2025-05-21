using GameStore.Data;
using GameStore.Dto;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GamesEndpoints {
    private const string GetGameEndpointName = "GetGame";

    // Extension method
    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        // Used the package MinimalApis.Extensions for data validation
        RouteGroupBuilder group = app.MapGroup("games").WithParameterValidation();

        // Get /games
        group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Games
                .Include(game => game.Genre)
                .Select(game => game.ToGameSummaryDto())
                .AsNoTracking()
                .ToListAsync());

        // Get /games/id
        group.MapGet("/{id:int}", async (int id, GameStoreContext dbContext) => {
            Game? game = await dbContext.Games.FindAsync(id);

            return game == null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDto());
        }).WithName(GetGameEndpointName);

        // Post /games
        group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) => {
            // Game? existingGame = await dbContext.Games.Where(game => game.Name == newGame.Name).FirstOrDefaultAsync();
            Game? existingGame = await dbContext.Games.FirstOrDefaultAsync(game => game.Name == newGame.Name);

            if (existingGame != null) return Results.Conflict("Game already exists");

            Genre? existingGenre = await dbContext.Genres.FindAsync(newGame.GenreId);

            if (existingGenre == null) return Results.NotFound("Genre not found");

            Game game = newGame.ToEntity(existingGenre);

            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game.ToGameSummaryDto());
        });

        // Put /games
        group.MapPut("/{id:int}", async (int id, UpdateGameDto updatedGame, GameStoreContext dbContext) => {
            Game? existingGame = await dbContext.Games.FindAsync(id);

            if (existingGame == null) return Results.NotFound();

            Genre? existingGenre = await dbContext.Genres.FindAsync(updatedGame.GenreId);

            if (existingGenre == null) return Results.NotFound("Genre not found");

            dbContext.Entry(existingGame).CurrentValues.SetValues(updatedGame.ToEntity(existingGenre, id));

            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // Delete /games
        group.MapDelete("/{id:int}", async (int id, GameStoreContext dbContext) => {
            await dbContext.Games.Where(game => game.Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}