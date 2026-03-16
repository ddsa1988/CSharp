using App.Dto.Project;
using App.Dto.ProjectComponent;
using App.Entities;

namespace App.Mapping;

public static class ProjectMapping {
    public static Project ToEntity(this CreateProjectDto projectDto) {
        Project project = new() {
            Name = projectDto.Name,
            Description = projectDto.Description,
            CreationDate = projectDto.CreationDate
        };

        return project;
    }

    public static Project ToEntity(this UpdateProjectDto projectDto, long id) {
        Project project = new() {
            Id = id,
            Name = projectDto.Name,
            Description = projectDto.Description,
            CreationDate = projectDto.CreationDate
        };

        return project;
    }

    public static ProjectDto ToDto(this Project project) {
        ProjectDto projectDto = new(
            project.Id, project.Name,
            project.Description,
            project.CreationDate,
            project.Components.Select(component => component.ToDto()).ToList()
        );

        return projectDto;
    }
}