using System.ComponentModel.DataAnnotations;

namespace App.Entities;

public class Project {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }

    public required DateOnly StartDate { get; init; }
    public IReadOnlyDictionary<Component, int> Components { get; } = new Dictionary<Component, int>();
}