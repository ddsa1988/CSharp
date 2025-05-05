namespace GameStore.Dto;

public record GameDetailsDto(int Id, string Name, int Genre, float Price, DateOnly ReleaseDate);