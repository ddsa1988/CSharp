using App.Dto.Component;
using App.Dto.Project;

namespace App.Dto.ProjectComponent;

public record ProjectComponentDto(
    long ProjectId,
    ProjectDto? Project,
    long ComponentId,
    ComponentDto? Component,
    int Quantity
);