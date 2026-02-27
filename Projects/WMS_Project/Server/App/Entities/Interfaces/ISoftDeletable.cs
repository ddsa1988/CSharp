namespace App.Entities.Interfaces;

public interface ISoftDeletable {
    public bool IsDeleted { get; init; }
}