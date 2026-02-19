using App.Data;
using App.Dto.Category;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class CategoryEndpoints {
    public static RouteGroupBuilder MapCategoriesEndpoints(this WebApplication app) {
        const string getCategoryEndpointName = "GetCategory";

        RouteGroupBuilder group = app.MapGroup("categories").WithParameterValidation();

        // GET
        group.MapGet("/",
            (WarehouseDbContext dbContext) => dbContext.Categories.Select(category => category.ToDto()).AsNoTracking());

        group.MapGet("/{id:long}", (long id, WarehouseDbContext dbContext) => {
            CategoryDto? categoryDto = dbContext.Categories.Find(id)?.ToDto();

            return categoryDto == null ? Results.NotFound() : Results.Ok(categoryDto);
        }).WithName(getCategoryEndpointName);

        // POST
        group.MapPost("/", (CreateCategoryDto createCategory, WarehouseDbContext dbContext) => {
            Category category = createCategory.ToEntity();

            dbContext.Categories.Add(category);
            dbContext.SaveChanges();

            return Results.CreatedAtRoute(getCategoryEndpointName, new { id = category.Id }, category.ToDto());
        });

        // PUT
        group.MapPut("/{id:long}", (long id, UpdateCategoryDto updateCategory, WarehouseDbContext dbContext) => {
            Category? existingCategory = dbContext.Categories.Find(id);

            if (existingCategory == null) return Results.NotFound();

            dbContext.Entry(existingCategory).CurrentValues.SetValues(updateCategory.ToEntity(id));
            dbContext.SaveChanges();

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id:long}", (long id, WarehouseDbContext dbContext) => {
            Category? existingCategory = dbContext.Categories.Find(id);

            if (existingCategory == null) return Results.NotFound();

            dbContext.Categories.Where(category => category.Id == id).ExecuteDelete();
            dbContext.SaveChanges();

            return Results.NoContent();
        });

        return group;
    }
}