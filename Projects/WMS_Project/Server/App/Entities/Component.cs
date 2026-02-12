using System.ComponentModel.DataAnnotations;

namespace App.Entities;

public class Component {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }
    public int Quantity { get; init; }
    public long CategoryId { get; init; }
    public Category? Category { get; init; }
    public long ManufacturerId { get; init; }
    public Manufacturer? Manufacturer { get; init; }
    public long LocationId { get; init; }
    public Location? Location { get; init; }
}