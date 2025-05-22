using BookStore.Data;
using BookStore.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("BookStore");
builder.Services.AddSqlite<BookStoreContext>(connectionString);

WebApplication app = builder.Build();

app.MapBooksEndpoints();
app.MapAuthorsEndpoints();
app.MapPublishersEndpoints();

await app.MigrateDatabaseAsync();

app.Run();