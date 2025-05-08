using SimpleToDoList.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapToDoListEndpoints();

app.Run();