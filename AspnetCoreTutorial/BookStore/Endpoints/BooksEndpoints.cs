using BookStore.Dto;

namespace BookStore.Endpoints;

public static class BooksEndpoints {
    private const string GetBookEndpoint = "GetBook";
    private static readonly List<BookDto> Books = Utils.Books.Create();
    private static int _nextId = Books.Count + 1;

    public static RouteGroupBuilder MapBooksEndpoints(this WebApplication app) {
        // Define groups of endpoints with a common prefix
        RouteGroupBuilder group = app.MapGroup("books").WithParameterValidation();

        // Get /books
        group.MapGet("/", () => Books);

        // Get /books/id
        group.MapGet("/{id:int}", (int id) => {
            BookDto? book = Books.Find(book => book.Id == id);

            return book == null ? Results.NotFound() : Results.Ok(book);
        }).WithName(GetBookEndpoint);

        // Post /books
        group.MapPost("/", (CreateBookDto newBook) => {
            int index = Books.FindIndex(book => book.Title == newBook.Title);

            if (index != -1) return Results.Conflict("Book already exists");

            var book = new BookDto(_nextId++, newBook.Title, newBook.Author, newBook.Publisher, newBook.Isbn,
                newBook.Edition,
                newBook.Price, newBook.PublishDate);

            Books.Add(book);

            return Results.CreatedAtRoute(GetBookEndpoint, new { id = book.Id }, book);
        });

        // Put /books/id
        group.MapPut("/{id:int}", (int id, UpdateBookDto updatedBook) => {
            int index = Books.FindIndex(book => book.Id == id);

            if (index == 1) return Results.NotFound();

            Books[index] = new BookDto(id, updatedBook.Title, updatedBook.Author, updatedBook.Publisher,
                updatedBook.Isbn, updatedBook.Edition, updatedBook.Price, updatedBook.PublishDate);

            return Results.NoContent();
        });

        // Delete /books/id
        group.MapDelete("/{id:int}", (int id) => {
            int index = Books.FindIndex(book => book.Id == id);

            if (index == -1) return Results.NotFound();

            Books.RemoveAt(index);

            _nextId--;

            return Results.NoContent();
        });

        return group;
    }
}