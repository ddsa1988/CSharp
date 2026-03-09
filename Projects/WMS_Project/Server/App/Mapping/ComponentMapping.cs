using App.Dto.Component;
using App.Entities;

namespace App.Mapping;

public static class ComponentMapping {
    public static Component ToEntity(this ComponentDto componentDto) {
        Component component = new() {
            Name = componentDto.Name,
            Description = componentDto.Description,
            CategoryId = componentDto.CategoryId,
            ManufacturerId = componentDto.ManufacturerId,
            LocationId = componentDto.LocationId
        };

        return component;
    }

    public static Component ToEntity(this ComponentDto componentDto, long id) {
        Component component = new() {
            Id = id,
            Name = componentDto.Name,
            Description = componentDto.Description,
            CategoryId = componentDto.CategoryId,
            ManufacturerId = componentDto.ManufacturerId,
            LocationId = componentDto.LocationId
        };

        return component;
    }

    public static ComponentDto ToDto(this Component component) {
        ComponentDto componentDto = new(
            component.Id, component.Name,
            component.Description,
            component.CategoryId,
            component.Category?.ToDto(),
            component.ManufacturerId,
            component.Manufacturer?.ToDto(),
            component.LocationId,
            component.Location?.ToDto()
        );

        return componentDto;
    }
}