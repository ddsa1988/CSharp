namespace BookStore.Dto.Book;

public record class BookDetailsDto(
    int Id,
    string Title,
    int Author,
    int Publisher,
    string Isbn,
    int Edition,
    float Price,
    DateOnly PublishDate);