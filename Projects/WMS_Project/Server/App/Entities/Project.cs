namespace App.Entities;

public class Project {
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required DateOnly KickOffDate { get; set; }
    public required Dictionary<Component, int> Components { get; set; }
}