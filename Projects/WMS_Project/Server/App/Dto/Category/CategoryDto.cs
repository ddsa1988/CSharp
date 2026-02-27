namespace App.Dto.Category;

public record CategoryDto(
    long Id,
    string Name,
    string? Description
);