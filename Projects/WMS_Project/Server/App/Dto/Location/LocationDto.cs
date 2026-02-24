namespace App.Dto.Location;

public record LocationDto(
    long Id,
    string Name,
    string? Description,
    bool IsDeleted
);