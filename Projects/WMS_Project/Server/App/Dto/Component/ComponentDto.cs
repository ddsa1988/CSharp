namespace App.Dto.Component;

public record ComponentDto(
    long Id,
    string Name,
    string? Description,
    bool IsDeleted,
    int Quantity,
    long CategoryId,
    long ManufacturerId,
    long LocationId
);