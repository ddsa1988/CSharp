using System.ComponentModel.DataAnnotations;

namespace App.Dto.ProjectComponent;

public class UpdateProjectComponentDto(
    [Required] long ProjectId,
    [Required] long ComponentId,
    [Required] int Quantity
);