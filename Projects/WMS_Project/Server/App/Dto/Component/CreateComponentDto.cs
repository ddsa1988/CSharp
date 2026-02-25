using System.ComponentModel.DataAnnotations;

namespace App.Dto.Component;

public record CreateComponentDto(
    [Required] [StringLength(30)] string Name,
    [StringLength(50)] string? Description,
    [Required] int Quantity,
    [Required] long CategoryId,
    [Required] long ManufacturerId,
    [Required] long LocationId
);