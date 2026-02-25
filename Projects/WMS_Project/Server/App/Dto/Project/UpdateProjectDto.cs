using System.ComponentModel.DataAnnotations;

namespace App.Dto.Project;

public record UpdateProjectDto(
    [Required] [StringLength(30)] string Name,
    [StringLength(50)] string? Description,
    [Required] DateOnly StartDate
);