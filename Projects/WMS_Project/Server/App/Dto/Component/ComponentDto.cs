namespace App.Dto.Component;

public record ComponentDto(
    long Id,
    string Name,
    string? Description,
    long CategoryId,
    long ManufacturerId,
    long LocationId
);