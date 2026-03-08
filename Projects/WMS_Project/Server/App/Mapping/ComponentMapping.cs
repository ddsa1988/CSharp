using App.Dto.Component;
using App.Entities;

namespace App.Mapping;

public static class ComponentMapping {
    public static Component ToEntity(this ComponentDto componentDto) {
        throw new NotImplementedException();
    }

    public static Component ToEntity(this ComponentDto componentDto, long id) {
        throw new NotImplementedException();
    }

    public static ComponentDto ToDto(this Component component) {
        throw new NotImplementedException();
    }
}