using System.ComponentModel.DataAnnotations;

namespace App.Dto.ProjectComponent;

public record UpdateProjectComponentDto(
    [Required] long ProjectId,
    [Required] long ComponentId,
    [Required] int Quantity
);