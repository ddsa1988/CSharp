using App.Data;
using App.Endpoints;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//string? warehouseConnection = builder.Configuration.GetConnectionString("WarehouseConnection");

string warehouseConnection =
    "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "Warehouse.db");

//builder.Services.AddSqlite<WarehouseDbContext>(warehouseConnection);

builder.Services.AddDbContext<WarehouseDbContext>(options => { options.UseSqlite(warehouseConnection); });

WebApplication app = builder.Build();

app.MapCategoriesEndpoints();

app.MigrateDb();

app.Run();