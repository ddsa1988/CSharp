using GameStore.Models;

namespace GameStore.Clients;

public static class GenresClient {
    private static readonly List<Genre> Genres = [
        new() { Id = 1, Name = "Fighting" },
        new() { Id = 2, Name = "Roleplaying" },
        new() { Id = 3, Name = "Sports" },
        new() { Id = 4, Name = "Racing" },
        new() { Id = 5, Name = "Kids and Family" }
    ];

    public static IEnumerable<Genre> GetGenres() => Genres;
}