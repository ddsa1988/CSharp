using System.ComponentModel.DataAnnotations;

namespace App.Entities;

public class Manufacturer {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }

    [MaxLength(50)] public string? Description { get; init; }
    public IReadOnlyCollection<Component> Components { get; } = new List<Component>();
}