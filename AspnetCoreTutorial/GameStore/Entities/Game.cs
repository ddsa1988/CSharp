using System.ComponentModel.DataAnnotations;

namespace GameStore.Entities;

public class Game {
    public int Id { get; init; }
    [StringLength(30)] public required string Name { get; init; }
    public required int GenreId { get; init; }
    public Genre? Genre { get; set; }
    public required float Price { get; init; }
    public DateOnly ReleaseDate { get; init; }
}