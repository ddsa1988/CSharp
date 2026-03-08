using System.ComponentModel.DataAnnotations;

namespace App.Dto.ProjectComponent;

public record CreateProjectComponentDto(
    [Required] long ProjectId,
    [Required] long ComponentId,
    [Required] int Quantity
);