namespace BookStore.Dto;

public record class BookDto(
    int Id,
    string Title,
    string Author,
    string Publisher,
    string Isbn,
    int Edition,
    float Price,
    DateOnly PublishDate);