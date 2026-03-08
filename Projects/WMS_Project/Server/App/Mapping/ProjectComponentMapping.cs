using App.Dto.ProjectComponent;
using App.Entities;

namespace App.Mapping;

public static class ProjectComponentMapping {
    public static ProjectComponent ToEntity(this CreateProjectComponentDto projectComponentDto) {
        ProjectComponent projectComponent = new() {
            ProjectId = projectComponentDto.ProjectId,
            ComponentId = projectComponentDto.ComponentId,
            Quantity = projectComponentDto.Quantity
        };

        return projectComponent;
    }

    public static ProjectComponent ToEntity(this UpdateProjectComponentDto projectComponentDto) {
        ProjectComponent projectComponent = new() {
            ProjectId = projectComponentDto.ProjectId,
            ComponentId = projectComponentDto.ComponentId,
            Quantity = projectComponentDto.Quantity
        };

        return projectComponent;
    }

    public static ProjectComponentDto ToDto(this ProjectComponent projectComponent) {
        ProjectComponentDto projectComponentDto = new(projectComponent.ProjectId, projectComponent.Project?.ToDto(),
            projectComponent.ComponentId, projectComponent.Component?.ToDto(), projectComponent.Quantity);

        return projectComponentDto;
    }
}