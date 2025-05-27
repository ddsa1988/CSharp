using BookStore.Data;
using BookStore.Dto.Book;
using BookStore.Entities;
using BookStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Endpoints;

public static class BooksEndpoints {
    private const string GetBookEndpoint = "GetBook";

    public static RouteGroupBuilder MapBooksEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("books").WithParameterValidation();

        // Get /books
        group.MapGet("/", async (BookStoreContext dbContext) => {
            return await dbContext.Book
                .Include(book => book.Author)
                .Include(book => book.Publisher)
                .Select(book => book.ToBookSummaryDto())
                .AsNoTracking()
                .ToListAsync();
        });

        // Get /books/id
        group.MapGet("/{id:int}", async (int id, BookStoreContext dbContext) => {
            Book? book = await dbContext.Book.FindAsync(id);

            return book == null ? Results.NotFound() : Results.Ok(book.ToBookDetailsDto());
        }).WithName(GetBookEndpoint);

        // Post /books
        group.MapPost("/", async (CreateBookDto newBook, BookStoreContext dbContext) => {
            Book? existingBook = await dbContext.Book.FirstOrDefaultAsync(book => book.Title == newBook.Title);

            if (existingBook != null) return Results.Conflict("Book already exists");

            Author? existingAuthor = await dbContext.Author.FindAsync(newBook.AuthorId);

            if (existingAuthor == null) return Results.NotFound("Author not found");

            Publisher? existingPublisher = await dbContext.Publisher.FindAsync(newBook.PublisherId);

            if (existingPublisher == null) return Results.NotFound("Publisher not found");

            Book book = newBook.ToEntity(existingAuthor, existingPublisher);

            dbContext.Book.Add(book);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetBookEndpoint, new { id = book.Id }, book.ToBookSummaryDto());
        });

        // Put /books/id
        group.MapPut("/{id:int}", async (int id, UpdateBookDto updatedBook, BookStoreContext dbContext) => {
            Book? existingBook = await dbContext.Book.FindAsync(id);

            if (existingBook == null) return Results.NotFound("Book not found");

            Author? existingAuthor = await dbContext.Author.FindAsync(updatedBook.AuthorId);

            if (existingAuthor == null) return Results.NotFound("Author not found");

            Publisher? existingPublisher = await dbContext.Publisher.FindAsync(updatedBook.PublisherId);

            if (existingPublisher == null) return Results.NotFound("Publisher not found");

            dbContext.Entry(existingPublisher).CurrentValues
                .SetValues(updatedBook.ToEntity(existingAuthor, existingPublisher, id));

            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // Delete /books/id
        group.MapDelete("/{id:int}",
            async (int id, BookStoreContext dbContext) => {
                await dbContext.Book.Where(book => book.Id == id).ExecuteDeleteAsync();

                return Results.NoContent();
            });

        return group;
    }
}