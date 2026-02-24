using System.ComponentModel.DataAnnotations;

namespace App.Dto.Location;

public record UpdateLocationDto(
    [Required] [StringLength(30)] string Name,
    [StringLength(50)] string? Description
);