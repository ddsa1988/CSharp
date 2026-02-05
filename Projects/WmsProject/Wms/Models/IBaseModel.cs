namespace Wms.Models;

public interface IBaseModel {
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}