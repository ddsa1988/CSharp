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
        group.MapGet("/", async (ToDoListContext dbContext) =>
            await dbContext.ToDoList
                .Select(todo => todo.ToDto())
                .AsNoTracking()
                .ToListAsync());

        // Get /todoList/id
        group.MapGet("/{id:int}", async (int id, ToDoListContext dbContext) => {
            ToDo? todo = await dbContext.ToDoList.FindAsync(id);

            return todo == null ? Results.NotFound() : Results.Ok(todo.ToDto());
        }).WithName(GetToDoEndpointName);

        // Post /todoList
        group.MapPost("/", async (CreateToDoDto newTodo, ToDoListContext dbContext) => {
            ToDo? existingTodo =
                await dbContext.ToDoList.FirstOrDefaultAsync(todo => todo.Description == newTodo.Description);

            if (existingTodo != null) return Results.Conflict("Todo already exists");

            ToDo todo = newTodo.ToEntity();

            dbContext.ToDoList.Add(todo);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetToDoEndpointName, new { id = todo.Id }, todo.ToDto());
        });

        // Put /todolist/id
        group.MapPut("/{id:int}", async (int id, UpdateToDoDto updatedTodo, ToDoListContext dbContext) => {
            ToDo? existingTodo = await dbContext.ToDoList.FindAsync(id);

            if (existingTodo == null) return Results.NotFound();

            dbContext.Entry(existingTodo).CurrentValues.SetValues(updatedTodo.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // Delete /todoList/id
        group.MapDelete("/{id:int}",
            async (int id, ToDoListContext dbContext) => {
                await dbContext.ToDoList.Where(todo => todo.Id == id).ExecuteDeleteAsync();
            });

        return group;
    }
}