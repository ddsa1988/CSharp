using App.Dto.Category;
using App.Entities;

namespace App.Mapping;

public static class CategoryMapping {
    public static Category ToEntity(this CreateCategoryDto categoryDto) {
        var category = new Category() {
            Name = categoryDto.Name,
            Description = categoryDto.Description,
            IsDeleted = false
        };

        return category;
    }

    public static CategoryDto ToDto(this Category category) {
        var categoryDto = new CategoryDto(category.Id, category.Name, category.Description, category.IsDeleted);

        return categoryDto;
    }
}