using BookStore.Data;
using BookStore.Dto.Author;
using BookStore.Entities;
using BookStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Endpoints;

public static class AuthorEndpoints {
    private const string GetAuthorEndpoint = "GetAuthor";

    public static RouteGroupBuilder MapAuthorsEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("authors").WithParameterValidation();

        // Get /authors
        group.MapGet("/", async (BookStoreContext dbContext) => {
            return await dbContext.Author
                .Select(author => author.ToDto())
                .AsNoTracking()
                .ToListAsync();
        });

        // Get /authors/id
        group.MapGet("/{id:int}", async (int id, BookStoreContext dbContext) => {
            Author? author = await dbContext.Author.FindAsync(id);

            return author == null ? Results.NotFound() : Results.Ok(author.ToDto());
        }).WithName(GetAuthorEndpoint);

        // Post /authors
        group.MapPost("/", async (CreateAuthorDto newAuthor, BookStoreContext dbContext) => {
            Author? existingAuthor =
                await dbContext.Author.FirstOrDefaultAsync(author => author.Name == newAuthor.Name);

            if (existingAuthor != null) return Results.Conflict("Author already exists");

            Author author = newAuthor.ToEntity();

            dbContext.Author.Add(author);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetAuthorEndpoint, new { id = author.Id }, author.ToDto());
        });

        // Put /authors/id
        group.MapPut("/{id:int}", async (int id, UpdateAuthorDto updatedAuthor, BookStoreContext dbContext) => {
            Author? existingAuthor = await dbContext.Author.FindAsync(id);

            if (existingAuthor == null) return Results.NotFound();

            dbContext.Entry(existingAuthor).CurrentValues.SetValues(updatedAuthor.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // Delete /authors/id
        group.MapDelete("/{id:int}",
            async (int id, BookStoreContext dbContext) => {
                await dbContext.Author.Where(author => author.Id == id).ExecuteDeleteAsync();

                return Results.NoContent();
            });

        return group;
    }
}