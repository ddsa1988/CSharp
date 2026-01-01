using Platform.Middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.UseMiddleware<Population>();
app.Run(async (context) => await context.Response.WriteAsync("Terminal Middleware Reached"));

app.MapGet("/", () => "Hello World!");

app.Run();