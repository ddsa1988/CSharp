namespace Wms.Models;

public class Category : IBaseModel {
    public long Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}