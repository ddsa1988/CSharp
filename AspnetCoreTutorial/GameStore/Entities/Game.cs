using System.ComponentModel.DataAnnotations;

namespace GameStore.Entities;

public class Game {
    public int Id { get; init; }
    [StringLength(30)] public required string Name { get; init; }
    public required Genre Genre { get; init; }
    public required float Price { get; init; }
    public required DateOnly ReleaseDate { get; init; }
}