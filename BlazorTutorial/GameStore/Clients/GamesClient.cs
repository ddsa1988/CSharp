using GameStore.Models;

namespace GameStore.Clients;

public static class GamesClient {
    private static readonly List<GameSummary> Games = [
        new() {
            Id = 1, Name = "Street Fighter II", Genre = "Fight", Price = 19.9, ReleaseDate = new DateOnly(1992, 9, 27)
        },
        new() {
            Id = 2, Name = "Final Fantasy XIV", Genre = "Roleplaying", Price = 59.99,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new() { Id = 3, Name = "Fifa 23", Genre = "Sports", Price = 69.99, ReleaseDate = new DateOnly(2022, 9, 27) }
    ];

    public static IEnumerable<GameSummary> GetGames() => Games;
}