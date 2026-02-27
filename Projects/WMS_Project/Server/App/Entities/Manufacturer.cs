using System.ComponentModel.DataAnnotations;
using App.Entities.Interfaces;

namespace App.Entities;

public class Manufacturer : IBaseEntity, ISoftDeletable {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }
    public bool IsDeleted { get; init; }
    public ICollection<Component> Components { get; init; } = new List<Component>();
}