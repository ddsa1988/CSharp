using System.ComponentModel.DataAnnotations;

namespace App.Entities;

public class Category {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }
}