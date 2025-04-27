namespace GameStore.Dto;

public abstract record CreateGameDto(string Name, string Genre, float Price, DateOnly ReleaseDate);