using Microsoft.EntityFrameworkCore;
using SimpleToDoList.Data;
using SimpleToDoList.Dto;
using SimpleToDoList.Entities;
using SimpleToDoList.Mapping;

namespace SimpleToDoList.Endpoints;

public static class ToDoListEndpoints {
    private const string GetToDoEndpointName = "GetToDoList";

    public static RouteGroupBuilder MapToDoListEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("todolist").WithParameterValidation();

        // Get /todoList
        group.MapGet("/", (ToDoListContext dbContext) =>
            dbContext.ToDoList
                .Select(todo => todo.ToDto())
                .AsNoTracking());

        // Get /todoList/id
        group.MapGet("/{id:int}", (int id, ToDoListContext dbContext) => {
            ToDo? todo = dbContext.ToDoList.Find(id);

            return todo == null ? Results.NotFound() : Results.Ok(todo.ToDto());
        }).WithName(GetToDoEndpointName);

        // Post /todoList
        group.MapPost("/", (CreateToDoDto newTodo, ToDoListContext dbContext) => {
            ToDo? existingTodo = dbContext.ToDoList.FirstOrDefault(todo => todo.Description == newTodo.Description);

            if (existingTodo != null) return Results.Conflict("Todo already exists");

            ToDo todo = newTodo.ToEntity();

            dbContext.ToDoList.Add(todo);
            dbContext.SaveChanges();

            return Results.CreatedAtRoute(GetToDoEndpointName, new { id = todo.Id }, todo.ToDto());
        });

        // Put /todolist/id
        group.MapPut("/{id:int}", (int id, UpdateToDoDto updatedTodo, ToDoListContext dbContext) => {
            ToDo? existingTodo = dbContext.ToDoList.Find(id);

            if (existingTodo == null) return Results.NotFound();

            dbContext.Entry(existingTodo).CurrentValues.SetValues(updatedTodo.ToEntity(id));
            dbContext.SaveChanges();

            return Results.NoContent();
        });

        // Delete /todoList/id
        group.MapDelete("/{id:int}",
            (int id, ToDoListContext dbContext) => {
                dbContext.ToDoList.Where(todo => todo.Id == id).ExecuteDelete();
            });

        return group;
    }
}