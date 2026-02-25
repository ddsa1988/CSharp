using System.ComponentModel.DataAnnotations;

namespace App.Dto.Manufacturer;

public record CreateManufacturerDto(
    [Required] [StringLength(30)] string Name,
    [StringLength(50)] string? Description
);