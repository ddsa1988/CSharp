using App.Dto.Category;

namespace App.Endpoints;

public static class CategoryEndpoints {
    private static readonly List<CategoryDto> Categories = [
        new(1, "Category 1", "Description 1"),
        new(2, "Category 2", "Description 2"),
        new(3, "Category 3", "Description 3"),
    ];

    public static RouteGroupBuilder MapCategoriesEndpoints(this WebApplication app) {
        const string getCategoryEndpointName = "GetCategory";

        RouteGroupBuilder group = app.MapGroup("categories").WithParameterValidation();

        group.MapGet("/", () => Categories);

        group.MapGet("/{id:long}", (long id) => {
            CategoryDto? category = Categories.FirstOrDefault(category => category.Id == id);

            return category == null ? Results.NotFound() : Results.Ok(category);
        }).WithName(getCategoryEndpointName);

        group.MapPost("/", (CreateCategoryDto createCategory) => {
            CategoryDto categoryDto = new(Categories.Count + 1, createCategory.Name, createCategory.Description);

            Categories.Add(categoryDto);

            return Results.CreatedAtRoute(getCategoryEndpointName, new { id = categoryDto.Id }, categoryDto);
        });

        group.MapPut("/{id:long}", (long id, UpdateCategoryDto updateCategory) => {
            int index = Categories.FindIndex(category => category.Id == id);

            if (index == -1) return Results.NotFound();

            Categories[index] = new CategoryDto(id, updateCategory.Name, updateCategory.Description);

            return Results.NoContent();
        });

        group.MapDelete("/{id:long}", (long id) => {
            Categories.RemoveAll(category => category.Id == id);

            return Results.NoContent();
        });

        return group;
    }
}