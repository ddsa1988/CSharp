using App.Data;
using App.Dto.Category;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class CategoryEndpoints {
    public static RouteGroupBuilder MapCategoryEndpoints(this WebApplication app) {
        const string getCategoryEndpointName = "GetCategory";

        RouteGroupBuilder group = app.MapGroup("categories").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) => {
            await dbContext.Categories
                .Select(category => category.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Category? category = await dbContext.Categories.FindAsync(id);

            return category == null ? Results.NotFound() : Results.Ok(category.ToDto());
        }).WithName(getCategoryEndpointName);

        // POST
        group.MapPost("/", async (CreateCategoryDto createCategory, WarehouseDbContext dbContext) => {
            Category newCategory = createCategory.ToEntity();

            await dbContext.Categories.AddAsync(newCategory);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(getCategoryEndpointName, new { id = newCategory.Id }, newCategory.ToDto());
        });

        // PUT
        group.MapPut("/{id:long}", async (long id, UpdateCategoryDto updateCategory, WarehouseDbContext dbContext) => {
            Category? existingCategory = await dbContext.Categories.FindAsync(id);

            if (existingCategory == null) return Results.NotFound();

            dbContext.Entry(existingCategory).CurrentValues.SetValues(updateCategory.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Category? existingCategory = await dbContext.Categories.FindAsync(id);

            if (existingCategory == null) return Results.NotFound();

            if (existingCategory.IsDeleted) return Results.NoContent();

            existingCategory.IsDeleted = true;

            dbContext.Entry(existingCategory).CurrentValues.SetValues(existingCategory);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}