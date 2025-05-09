using SimpleToDoList.Dto;

namespace SimpleToDoList.Endpoints;

public static class ToDoListEndpoints {
    private const string GetToDoEndpointName = "GetToDoList";
    private static readonly List<ToDoDto> ToDoList = Utils.ToDoList.Create();
    private static int _nextId = ToDoList.Count + 1;

    public static WebApplication MapToDoListEndpoints(this WebApplication app) {
        // Get /todoList
        app.MapGet("/todoList", () => ToDoList);

        // Get /todoList/id
        app.MapGet("/todoList/{id:int}", (int id) => {
            ToDoDto? todo = ToDoList.Find(todo => todo.Id == id);

            return todo == null ? Results.NotFound() : Results.Ok(todo);
        }).WithName(GetToDoEndpointName);

        // Post /todoList
        app.MapPost("/todoList", (CreateToDoDto newTodo) => {
            var todo = new ToDoDto(_nextId++, newTodo.Description, false);

            ToDoList.Add(todo);

            return Results.CreatedAtRoute(GetToDoEndpointName, new { id = todo.Id }, todo);
        });

        // Put /todolist/id
        app.MapPut("/todoList/{id:int}", (int id, UpdateToDoDto updateTodo) => {
            int index = ToDoList.FindIndex(todo => todo.Id == id);

            if (index == -1) return Results.NotFound();

            ToDoList[index] = new ToDoDto(id, updateTodo.Description, updateTodo.IsCompleted);

            return Results.NoContent();
        });

        // Delete /todoList/id
        app.MapDelete("/todoList/{id:int}", (int id) => {
            int index = ToDoList.FindIndex(todo => todo.Id == id);

            if (index == -1) return Results.NotFound();

            ToDoList.RemoveAt(index);

            return Results.NoContent();
        });

        return app;
    }
}