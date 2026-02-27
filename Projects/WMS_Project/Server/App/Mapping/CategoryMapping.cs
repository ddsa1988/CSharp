using App.Dto.Category;
using App.Entities;

namespace App.Mapping;

public static class CategoryMapping {
    public static Category ToEntity(this CreateCategoryDto categoryDto) {
        Category category = new() {
            Name = categoryDto.Name,
            Description = categoryDto.Description,
            IsDeleted = false
        };

        return category;
    }

    public static CategoryDto ToDto(this Category category) {
        CategoryDto categoryDto = new(category.Id, category.Name, category.Description);

        return categoryDto;
    }

    public static Category ToEntity(this UpdateCategoryDto categoryDto, long id) {
        Category category = new() {
            Id = id,
            Name = categoryDto.Name,
            Description = categoryDto.Description,
            IsDeleted = false
        };

        return category;
    }
}