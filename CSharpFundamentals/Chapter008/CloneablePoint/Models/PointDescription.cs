using System.Drawing;

namespace CloneablePoint.Models;

internal class PointDescription {
    public string Name { get; set; }
    public Guid Id { get; set; }

    public PointDescription() {
        Name = "No-name";
        Id = Guid.NewGuid();
    }
}