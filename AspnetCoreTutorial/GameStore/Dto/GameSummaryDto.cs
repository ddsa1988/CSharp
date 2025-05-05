namespace GameStore.Dto;

public record GameSummaryDto(int Id, string Name, string Genre, float Price, DateOnly ReleaseDate);