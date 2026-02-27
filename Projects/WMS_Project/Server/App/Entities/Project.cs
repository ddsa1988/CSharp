using System.ComponentModel.DataAnnotations;
using App.Entities.Interfaces;

namespace App.Entities;

public class Project : IBaseEntity, ISoftDeletable {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }
    public bool IsDeleted { get; init; }
    public required DateOnly CreationDate { get; init; }
    public ICollection<ProjectComponent> ProjectComponents { get; init; } = new List<ProjectComponent>();
}