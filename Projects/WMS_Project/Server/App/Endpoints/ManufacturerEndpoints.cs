using App.Data;
using App.Dto.Manufacturer;
using App.Entities;
using App.Mapping;
using Microsoft.EntityFrameworkCore;

namespace App.Endpoints;

public static class ManufacturerEndpoints {
    public static RouteGroupBuilder MapManufacturerEndpoints(this WebApplication app) {
        const string getManufacturerEndpointName = "GetManufacturer";

        RouteGroupBuilder group = app.MapGroup("manufacturers").WithParameterValidation();

        // GET
        group.MapGet("/", async (WarehouseDbContext dbContext) =>
            await dbContext.Manufacturers
                .Select(manufacturer => manufacturer.ToDto())
                .AsNoTracking()
                .ToListAsync());

        group.MapGet("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Manufacturer? manufacturer = await dbContext.Manufacturers.FindAsync(id);

            return manufacturer == null ? Results.NotFound() : Results.Ok(manufacturer.ToDto());
        }).WithName(getManufacturerEndpointName);

        // POST
        group.MapPost("/",
            async (CreateManufacturerDto createManufacturer, WarehouseDbContext dbContext) => {
                Manufacturer newManufacturer = createManufacturer.ToEntity();

                await dbContext.AddAsync(newManufacturer);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(getManufacturerEndpointName,
                    new { id = newManufacturer.Id }, newManufacturer.ToDto());
            });

        // PUT
        group.MapPut("/{id:long}",
            async (long id, UpdateManufacturerDto updateManufacturer, WarehouseDbContext dbContext) => {
                Manufacturer? existingManufacturer = await dbContext.Manufacturers.FindAsync(id);

                if (existingManufacturer == null) return Results.NotFound();

                dbContext.Entry(existingManufacturer).CurrentValues.SetValues(updateManufacturer.ToEntity(id));
                await dbContext.SaveChangesAsync();

                return Results.NoContent();
            });

        // DELETE
        group.MapDelete("/{id:long}", async (long id, WarehouseDbContext dbContext) => {
            Manufacturer? existingManufacturer = await dbContext.Manufacturers.FindAsync(id);

            if (existingManufacturer == null) return Results.NotFound();

            if (existingManufacturer.IsDeleted) return Results.NoContent();

            existingManufacturer.IsDeleted = true;

            dbContext.Entry(existingManufacturer).CurrentValues.SetValues(existingManufacturer);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}