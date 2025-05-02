using GameStore.Dto;

namespace GameStore.Endpoints;

public static class GamesEndpoints {
    private const string GetGameEndpointName = "GetGame";
    private static readonly List<GameDto> Games = Utils.Games.Create();

    // Extension method
    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        // Used the package MinimalApis.Extensions for data validation
        RouteGroupBuilder group = app.MapGroup("games").WithParameterValidation();

        // Get /games
        group.MapGet("/", () => Games);

        // Get /games/id
        group.MapGet("/{id:int}", (int id) => {
            GameDto? game = Games.Find(game => game.Id == id);

            return game == null ? Results.NotFound() : Results.Ok(game);
        }).WithName(GetGameEndpointName);

        // Post /games
        group.MapPost("/", (CreateGameDto newGame) => {
            var game = new GameDto(Games.Count + 1, newGame.Name, newGame.Genre, newGame.Price, newGame.ReleaseDate);

            Games.Add(game);

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
        });

        // Put /games
        group.MapPut("/{id:int}", (int id, UpdateGameDto updateGame) => {
            int index = Games.FindIndex(game => game.Id == id);

            if (index == -1) return Results.NotFound();

            Games[index] = new GameDto(id, updateGame.Name, updateGame.Genre, updateGame.Price, updateGame.ReleaseDate);

            return Results.NoContent();
        });

        // Delete /games
        group.MapDelete("/{id:int}", (int id) => {
            int index = Games.FindIndex(game => game.Id == id);

            if (index == -1) return Results.NotFound();

            Games.RemoveAt(index);

            return Results.NoContent();
        });

        return group;
    }
}