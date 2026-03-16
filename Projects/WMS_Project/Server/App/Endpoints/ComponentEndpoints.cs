using App.Data;
using App.Dto.Component;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class ComponentEndpoints {
    public static RouteGroupBuilder MapComponentEndpoints(this WebApplication app) {
        const string getComponentEndpointName = "GetComponent";

        RouteGroupBuilder group = app.MapGroup("components").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) => {
            await dbContext.Components
                .Include(component => component.Category)
                .Include(component => component.Manufacturer)
                .Include(component => component.Location)
                .Select(component => component.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Component? component = await dbContext.Components.FindAsync(id);

            return component == null ? Results.NotFound() : Results.Ok(component.ToDto());
        }).WithName(getComponentEndpointName);

        // POST
        group.MapPost("/", async (CreateComponentDto createComponent, WarehouseDbContext dbContext) => {
            Component newComponent = createComponent.ToEntity();

            await dbContext.Components.AddAsync(newComponent);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(getComponentEndpointName, new { id = newComponent.Id }, newComponent.ToDto());
        });

        // PUT
        group.MapPut("/{id:long}",
            async (long id, UpdateComponentDto updateComponent, WarehouseDbContext dbContext) => {
                Component? existingComponent = await dbContext.Components.FindAsync(id);

                if (existingComponent == null) return Results.NotFound();

                dbContext.Entry(existingComponent).CurrentValues.SetValues(updateComponent.ToEntity(id));
                await dbContext.SaveChangesAsync();

                return Results.NoContent();
            });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Component? existingComponent = await dbContext.Components.FindAsync(id);

            if (existingComponent == null) return Results.NotFound();

            if (existingComponent.IsDeleted) return Results.NoContent();

            existingComponent.IsDeleted = true;

            dbContext.Entry(existingComponent).CurrentValues.SetValues(existingComponent);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}