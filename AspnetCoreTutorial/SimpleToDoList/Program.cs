using SimpleToDoList.Data;
using SimpleToDoList.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("SimpleToDoList");
builder.Services.AddSqlite<ToDoListContext>(connectionString);

WebApplication app = builder.Build();

app.MapToDoListEndpoints();

await app.MigrateDatabaseAsync();

app.Run();