namespace App.Entities;

public class Component {
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
    public long ManufacturerId { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    public long LocationId { get; set; }
    public Location? Location { get; set; }
}