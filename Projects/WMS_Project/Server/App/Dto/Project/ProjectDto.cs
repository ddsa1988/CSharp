namespace App.Dto.Project;

public record ProjectDto(
    long Id,
    string Name,
    string? Description,
    bool IsDeleted,
    DateOnly StartDate
);