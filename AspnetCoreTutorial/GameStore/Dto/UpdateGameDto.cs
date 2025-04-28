namespace GameStore.Dto;

public record UpdateGameDto(string Name, string Genre, float Price, DateOnly ReleaseDate);