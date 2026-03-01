using App.Data;
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


        // PUT


        // DELETE

        return group;
    }
}