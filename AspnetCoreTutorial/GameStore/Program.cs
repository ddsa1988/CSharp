using GameStore.Data;
using GameStore.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connectionString);

WebApplication app = builder.Build();

app.MapGamesEndpoints();

app.MigrateDb();

app.Run();