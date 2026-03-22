using App.Dto.Manufacturer;
using App.Entities;

namespace App.Mapping;

public static class ManufacturerMapping {
    public static Manufacturer ToEntity(this CreateManufacturerDto manufacturerDto) {
        Manufacturer manufacturer = new() {
            Name = manufacturerDto.Name,
            Description = manufacturerDto.Description,
        };

        return manufacturer;
    }

    public static Manufacturer ToEntity(this UpdateManufacturerDto manufacturerDto, long id) {
        Manufacturer manufacturer = new() {
            Id = id,
            Name = manufacturerDto.Name,
            Description = manufacturerDto.Description,
        };

        return manufacturer;
    }

    public static ManufacturerDto ToDto(this Manufacturer manufacturer) {
        ManufacturerDto manufacturerDto = new(manufacturer.Id, manufacturer.Name, manufacturer.Description, manufacturer.IsDeleted);

        return manufacturerDto;
    }
}