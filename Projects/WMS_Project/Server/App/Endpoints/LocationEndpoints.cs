using App.Data;
using App.Dto.Location;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class LocationEndpoints {
    public static RouteGroupBuilder MapLocationEndpoints(this WebApplication app) {
        const string getLocationEndpointName = "GetLocation";

        RouteGroupBuilder group = app.MapGroup("locations").WithParameterValidation();

        // GET
        group.MapGet("/",
            async (WarehouseDbContext dbContext) => {
                await dbContext.Locations
                    .Select(location => location.ToDto())
                    .AsNoTracking()
                    .ToListAsync();
            });

        group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Location? location = await dbContext.Locations.FindAsync(id);

            return location == null ? Results.NotFound() : Results.Ok(location.ToDto());
        }).WithName(getLocationEndpointName);

        // POST
        group.MapPost("/", async (CreateLocationDto createLocation, WarehouseDbContext dbContext) => {
            Location newLocation = createLocation.ToEntity();

            await dbContext.Locations.AddAsync(newLocation);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(getLocationEndpointName, new { id = newLocation.Id }, newLocation.ToDto());
        });

        // PUT
        group.MapPut("/{id:long}", async (long id, UpdateLocationDto updateLocation, WarehouseDbContext dbContext) => {
            Location? existingLocation = await dbContext.Locations.FindAsync(id);

            if (existingLocation == null) return Results.NotFound();

            dbContext.Entry(existingLocation).CurrentValues.SetValues(updateLocation.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Location? existingLocation = await dbContext.Locations.FindAsync(id);

            if (existingLocation == null) return Results.NotFound();

            if (existingLocation.IsDeleted) return Results.NoContent();

            existingLocation.IsDeleted = true;

            dbContext.Entry(existingLocation).CurrentValues.SetValues(existingLocation);

            return Results.NoContent();
        });

        return group;
    }
}