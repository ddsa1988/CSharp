namespace GameStore.Dto;

public record CreateGameDto(string Name, string Genre, float Price, DateOnly ReleaseDate);