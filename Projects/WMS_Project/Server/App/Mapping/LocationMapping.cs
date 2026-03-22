using App.Dto.Location;
using App.Entities;

namespace App.Mapping;

public static class LocationMapping {
    public static Location ToEntity(this CreateLocationDto locationDto) {
        Location location = new() {
            Name = locationDto.Name,
            Description = locationDto.Description
        };

        return location;
    }

    public static Location ToEntity(this UpdateLocationDto locationDto, long id) {
        Location location = new() {
            Id = id,
            Name = locationDto.Name,
            Description = locationDto.Description
        };

        return location;
    }

    public static LocationDto ToDto(this Location location) {
        LocationDto locationDto = new(location.Id, location.Name, location.Description, location.IsDeleted);

        return locationDto;
    }
}