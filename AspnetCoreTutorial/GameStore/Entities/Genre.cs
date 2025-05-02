using System.ComponentModel.DataAnnotations;

namespace GameStore.Entities;

public class Genre {
    public required int Id { get; init; }
    [StringLength(30)] public required string Name { get; init; }
}