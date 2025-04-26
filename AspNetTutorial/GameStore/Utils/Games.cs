using GameStore.Dto;

namespace GameStore.Utils;

public static class Games {
    public static List<GameDto> GetGames() {
        List<GameDto> games = [
            new GameDto() {
                Id = 1, Name = "Street Fighter II", Genre = "Fighting", Price = 19.99F,
                ReleaseDate = new DateOnly(1992, 7, 15)
            },
            new GameDto() {
                Id = 2, Name = "Final Fantasy XIV", Genre = "Roleplaying", Price = 59.99F,
                ReleaseDate = new DateOnly(2010, 9, 30)
            },
            new GameDto()
                { Id = 3, Name = "Fifa 23", Genre = "Sports", Price = 69.99F, ReleaseDate = new DateOnly(2022, 9, 27) },
        ];

        return games;
    }
}