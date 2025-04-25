namespace GameStore.Dto;

public record GameDto(int Id, string Name, string Genre, float Price, DateOnly ReleaseDate);