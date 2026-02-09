using App.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

WebApplication app = builder.Build();

app.MapCategoriesEndpoints();

app.Run();