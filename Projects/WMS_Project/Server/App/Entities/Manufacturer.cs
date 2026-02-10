namespace App.Entities;

public class Manufacturer {
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required List<Component> Components { get; set; }
}