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
        group.MapGet("/",
            (GameStoreContext dbContext) =>
                dbContext.Games
                    .Include(game => game.Genre)
                    .Select(game => game.ToGameSummaryDto())
                    .AsNoTracking());

        // Get /games/id
        group.MapGet("/{id:int}", (int id, GameStoreContext dbContext) => {
            Game? game = dbContext.Games.Find(id);

            return game == null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDto());
        }).WithName(GetGameEndpointName);

        // Post /games
        group.MapPost("/", (CreateGameDto newGame, GameStoreContext dbContext) => {
            Game game = newGame.ToEntity();
            game.Genre = dbContext.Genres.Find(newGame.GenreId);

            dbContext.Games.Add(game);
            dbContext.SaveChanges();

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game.ToGameSummaryDto());
        });

        // Put /games
        group.MapPut("/{id:int}", (int id, UpdateGameDto updateGame, GameStoreContext dbContext) => {
            Game? existingGame = dbContext.Games.Find(id);

            if (existingGame == null) return Results.NotFound();

            dbContext.Entry(existingGame).CurrentValues.SetValues(updateGame.ToEntity(id));

            return Results.NoContent();
        });

        // Delete /games
        group.MapDelete("/{id:int}", (int id, GameStoreContext dbContext) => {
            dbContext.Games
                .Where(game => game.Id == id)
                .ExecuteDelete();

            return Results.NoContent();
        });

        return group;
    }
}