using App.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App.Entities;

[PrimaryKey(nameof(ProjectId), nameof(ComponentId))]
public class ProjectComponent : ISoftDeletable {
    public long ProjectId { get; init; }
    public Project? Project { get; init; }
    public long ComponentId { get; init; }
    public Component? Component { get; init; }
    public int Quantity { get; init; }
    public bool IsDeleted { get; set; }
}