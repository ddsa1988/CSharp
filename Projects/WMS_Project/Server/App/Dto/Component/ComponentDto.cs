using App.Dto.Category;
using App.Dto.Location;
using App.Dto.Manufacturer;

namespace App.Dto.Component;

public record ComponentDto(
    long Id,
    string Name,
    string? Description,
    long CategoryId,
    CategoryDto? Category,
    long ManufacturerId,
    ManufacturerDto? Manufacturer,
    long LocationId,
    LocationDto? Location
);