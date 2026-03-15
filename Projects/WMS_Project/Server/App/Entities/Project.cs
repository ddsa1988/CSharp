using System.ComponentModel.DataAnnotations;
using App.Dto.ProjectComponent;
using App.Entities.Interfaces;

namespace App.Entities;

public class Project : IBaseEntity {
    public long Id { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public string? Description { get; init; }
    public bool IsDeleted { get; set; }
    public required DateOnly CreationDate { get; init; }
    public ICollection<ProjectComponentDto> Components { get; set; } = new List<ProjectComponentDto>();
}