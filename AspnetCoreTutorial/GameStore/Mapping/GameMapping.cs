using GameStore.Dto;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class GameMapping {
    // Create extension methods for the CreateGameDto and the Game classes.
    public static Game ToEntity(this CreateGameDto game) {
        return new Game() {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static Game ToEntity(this UpdateGameDto game, int id) {
        return new Game() {
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static GameSummaryDto ToGameSummaryDto(this Game game) {
        return new GameSummaryDto(game.Id, game.Name, game.Genre!.Name, game.Price, game.ReleaseDate);
    }

    public static GameDetailsDto ToGameDetailsDto(this Game game) {
        return new GameDetailsDto(game.Id, game.Name, game.GenreId, game.Price, game.ReleaseDate);
    }
}