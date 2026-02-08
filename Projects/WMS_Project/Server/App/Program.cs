using App.Dto.Category;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

List<CategoryDto> categories = [
    new(1, "Category 1", "Description 1"),
    new(2, "Category 2", "Description 2"),
    new(3, "Category 3", "Description 3"),
];

const string getCategoryEndpointName = "GetCategory";

app.MapGet("/", () => "Hello World!");

app.MapGet("/categories", () => categories);

app.MapGet("/categories/{id:long}", (long id) => {
    CategoryDto? category = categories.FirstOrDefault(category => category.Id == id);

    return category == null ? Results.NotFound() : Results.Ok(category);
}).WithName(getCategoryEndpointName);

app.MapPost("/categories", (CreateCategoryDto createCategory) => {
    CategoryDto categoryDto = new(categories.Count + 1, createCategory.Name, createCategory.Description);

    categories.Add(categoryDto);

    return Results.CreatedAtRoute(getCategoryEndpointName, new { id = categoryDto.Id }, categoryDto);
});

app.MapPut("/categories/{id:long}", (long id, UpdateCategoryDto updateCategory) => {
    int index = categories.FindIndex(category => category.Id == id);

    if (index == -1) return Results.NotFound();

    categories[index] = new CategoryDto(id, updateCategory.Name, updateCategory.Description);

    return Results.NoContent();
});

app.MapDelete("/categories/{id:long}", (long id) => {
    categories.RemoveAll(category => category.Id == id);

    return Results.NoContent();
});

app.Run();