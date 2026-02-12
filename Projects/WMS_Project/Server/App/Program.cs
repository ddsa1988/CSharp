using App.Data;
using App.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? warehouseConnection = builder.Configuration.GetConnectionString("WarehouseConnection");

builder.Services.AddSqlite<WarehouseDbContext>(warehouseConnection);

//builder.Services.AddDbContext<WarehouseDbContext>(options => { options.UseSqlite(warehouseConnection); });

WebApplication app = builder.Build();

app.MapCategoriesEndpoints();

app.Run();