namespace App.Entities;

public class Location {
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}