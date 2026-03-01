using System.ComponentModel.DataAnnotations;

namespace App.Dto.ProjectComponent;

public class CreateProjectComponentDto(
    [Required] long ProjectId,
    [Required] long ComponentId,
    [Required] int Quantity
);