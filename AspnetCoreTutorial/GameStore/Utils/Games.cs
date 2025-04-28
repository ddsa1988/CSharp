using GameStore.Dto;

namespace GameStore.Utils;

public static class Games {
    public static List<GameDto> Create() {
        List<GameDto> games = [
            new GameDto(1, "Street Fighter II", "Fighting", 19.99F, new DateOnly(1992, 7, 15)),
            new GameDto(2, "Final Fantasy XIV", "Roleplaying", 59.99F, new DateOnly(2010, 9, 30)),
            new GameDto(3, "Fifa 23", "Sports", 69.99F, new DateOnly(2022, 9, 27)),
        ];

        return games;
    }
}