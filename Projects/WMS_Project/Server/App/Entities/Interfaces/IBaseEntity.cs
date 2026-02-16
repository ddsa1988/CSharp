namespace App.Entities.Interfaces;

public interface IBaseEntity {
    public long Id { get; init; }
    public string Name { get; init; }
    public string? Description { get; init; }
}