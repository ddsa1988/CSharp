using System.ComponentModel.DataAnnotations;

namespace App.Dto.Category;

public record UpdateCategoryDto(
    [Required] [StringLength(30)] string Name,
    [StringLength(50)] string Description,
    [Required] bool IsDeleted
);