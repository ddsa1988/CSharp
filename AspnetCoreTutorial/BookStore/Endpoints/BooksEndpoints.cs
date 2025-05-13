using BookStore.Dto;

namespace BookStore.Endpoints;

public static class BooksEndpoints {
    private const string GetBookEndpoint = "GetBook";
    private static readonly List<BookDto> Books = Utils.Books.Create();
    private static int _nextId = Books.Count + 1;

    public static WebApplication MapBooksEndpoints(this WebApplication app) {
        // Get /books
        app.MapGet("/books", () => Books);

        // Get /books/id
        app.MapGet("/books/{id:int}", (int id) => {
            BookDto? book = Books.Find(book => book.Id == id);

            return book == null ? Results.NotFound() : Results.Ok(book);
        }).WithName(GetBookEndpoint);

        // Post /books
        app.MapPost("/books", (CreateBookDto newBook) => {
            int index = Books.FindIndex(book => book.Title == newBook.Title);

            if (index != -1) return Results.Conflict("Book already exists");

            var book = new BookDto(_nextId++, newBook.Title, newBook.Author, newBook.Publisher, newBook.Edition,
                newBook.Isbn, newBook.Price, newBook.PublishDate);

            Books.Add(book);

            return Results.CreatedAtRoute(GetBookEndpoint, new { id = book.Id }, book);
        });

        return app;
    }
}