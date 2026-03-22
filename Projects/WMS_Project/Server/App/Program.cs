using App.Data;
using App.Endpoints;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//string? warehouseConnection = builder.Configuration.GetConnectionString("WarehouseConnection");

string warehouseConnection =
    "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "Warehouse.db");

//builder.Services.AddSqlite<WarehouseDbContext>(warehouseConnection);

builder.Services.AddDbContext<WarehouseDbContext>(options => { options.UseSqlite(warehouseConnection); });

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

WebApplication app = builder.Build();

app.UseCors("AllowAll");

app.MapCategoryEndpoints();
app.MapManufacturerEndpoints();
app.MapLocationEndpoints();
app.MapComponentEndpoints();
app.MapProjectEndpoints();
app.MapProjectComponentEndpoints();

await app.MigrateDbAsync();

app.Run();