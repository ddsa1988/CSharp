using SimpleToDoList.Dto;

namespace SimpleToDoList.Endpoints;

public static class ToDoListEndpoints {
    private const string GetToDoEndpointName = "GetToDoList";
    private static readonly List<ToDoDto> ToDoList = Utils.ToDoList.Create();

    public static WebApplication MapToDoListEndpoints(this WebApplication app) {
        // Get /todoList
        app.MapGet("/todoList", () => ToDoList);

        // Get /todoList/id
        app.MapGet("/todoList/{id:int}", (int id) => {
            ToDoDto? todo = ToDoList.Find(todo => todo.Id == id);

            return todo == null ? Results.NotFound() : Results.Ok(todo);
        }).WithName(GetToDoEndpointName);

        return app;
    }
}