using App.Data;
using App.Dto.Category;
using App.Entities;

namespace App.Endpoints;

public static class CategoryEndpoints {
    private static readonly List<CategoryDto> Categories = [
        new(1, "Category 1", "Description 1", false),
        new(2, "Category 2", "Description 2", false),
        new(3, "Category 3", "Description 3", false),
    ];

    public static RouteGroupBuilder MapCategoriesEndpoints(this WebApplication app) {
        const string getCategoryEndpointName = "GetCategory";

        RouteGroupBuilder group = app.MapGroup("categories").WithParameterValidation();

        // GET
        group.MapGet("/", () => Categories);

        group.MapGet("/{id:long}", (long id) => {
            CategoryDto? category = Categories.FirstOrDefault(category => category.Id == id);

            return category == null ? Results.NotFound() : Results.Ok(category);
        }).WithName(getCategoryEndpointName);

        // POST
        group.MapPost("/", (CreateCategoryDto createCategory, WarehouseDbContext dbContext) => {
            Category category = new()
                { Name = createCategory.Name, Description = createCategory.Description, IsDeleted = false };

            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            return Results.CreatedAtRoute(getCategoryEndpointName, new { id = category.Id }, category);
        });

        // PUT
        group.MapPut("/{id:long}", (long id, UpdateCategoryDto updateCategory) => {
            int index = Categories.FindIndex(category => category.Id == id);

            if (index == -1) return Results.NotFound();

            Categories[index] = new CategoryDto(id, updateCategory.Name, updateCategory.Description,
                updateCategory.IsDeleted);

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id:long}", (long id) => {
            Categories.RemoveAll(category => category.Id == id && category.IsDeleted);

            return Results.NoContent();
        });

        return group;
    }
}