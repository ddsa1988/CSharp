using Microsoft.EntityFrameworkCore;

namespace App.Entities;

[PrimaryKey(nameof(ProjectId), nameof(ComponentId))]
public class ProjectComponent {
    public long ProjectId { get; init; }
    public Project? Project { get; init; }
    public long ComponentId { get; init; }
    public Component? Component { get; init; }
    public int Quantity { get; init; }
}