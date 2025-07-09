namespace GameStore.Models;

public class GameSummary {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public double Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}