using App.Dto;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

IEnumerable<CategoryDto> categories = [
    new(1, "Category 1", "Description 1"),
    new(2, "Category 2", "Description 2"),
    new(3, "Category 3", "Description 3"),
];

app.MapGet("/", () => "Hello World!");

app.MapGet("/categories", () => categories);

app.MapGet("/categories/{id:long}", (long id) => {
    CategoryDto? category = categories.FirstOrDefault(category => category.Id == id);

    return category == null ? Results.NotFound() : Results.Ok(category);
});

app.Run();