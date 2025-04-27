namespace GameStore.Dto;

public abstract record UpdateGameDto(string Name, string Genre, float Price, DateOnly ReleaseDate);