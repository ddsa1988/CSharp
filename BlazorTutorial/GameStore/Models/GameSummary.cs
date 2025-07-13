namespace GameStore.Models;

public class GameSummary {
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string Genre { get; init; }
    public double Price { get; init; }
    public DateOnly ReleaseDate { get; init; }
}