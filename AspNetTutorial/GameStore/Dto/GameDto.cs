namespace GameStore.Dto;

public record GameDto() {
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Genre { get; init; } = string.Empty;
    public float Price { get; init; }
    public DateOnly ReleaseDate { get; init; }
}