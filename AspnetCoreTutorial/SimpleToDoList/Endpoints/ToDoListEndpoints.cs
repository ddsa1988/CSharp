using SimpleToDoList.Dto;

namespace SimpleToDoList.Endpoints;

public static class ToDoListEndpoints {
    private const string GetToDoEndpointName = "GetToDoList";
    private static readonly List<ToDoDto> ToDoList = Utils.ToDoList.Create();
    private static int _nextId = ToDoList.Count + 1;

    public static RouteGroupBuilder MapToDoListEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("todolist").WithParameterValidation();

        // Get /todoList
        group.MapGet("/", () => ToDoList);

        // Get /todoList/id
        group.MapGet("/{id:int}", (int id) => {
            ToDoDto? todo = ToDoList.Find(todo => todo.Id == id);

            return todo == null ? Results.NotFound() : Results.Ok(todo);
        }).WithName(GetToDoEndpointName);

        // Post /todoList
        group.MapPost("/", (CreateToDoDto newTodo) => {
            int index = ToDoList.FindIndex(todo => todo.Description == newTodo.Description);

            if (index != -1) return Results.Conflict("Todo already exists");

            var todo = new ToDoDto(_nextId++, newTodo.Description, false);

            ToDoList.Add(todo);

            return Results.CreatedAtRoute(GetToDoEndpointName, new { id = todo.Id }, todo);
        });

        // Put /todolist/id
        group.MapPut("/{id:int}", (int id, UpdateToDoDto updateTodo) => {
            int index = ToDoList.FindIndex(todo => todo.Id == id);

            if (index == -1) return Results.NotFound();

            ToDoList[index] = new ToDoDto(id, updateTodo.Description, updateTodo.IsCompleted);

            return Results.NoContent();
        });

        // Delete /todoList/id
        group.MapDelete("/{id:int}", (int id) => {
            int index = ToDoList.FindIndex(todo => todo.Id == id);

            if (index == -1) return Results.NotFound();

            ToDoList.RemoveAt(index);

            return Results.NoContent();
        });

        return group;
    }
}