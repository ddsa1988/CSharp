using BookStore.Dto.Book;
using BookStore.Entities;

namespace BookStore.Mapping;

public static class BookMapping {
    public static Book ToEntity(this CreateBookDto book, Author author, Publisher publisher) {
        return new Book() {
            Title = book.Title,
            Author = author,
            Publisher = publisher,
            Isbn = book.Isbn,
            Edition = book.Edition,
            Price = book.Price,
            PublishDate = book.PublishDate
        };
    }

    public static Book ToEntity(this UpdateBookDto book, Author author, Publisher publisher, int id) {
        return new Book() {
            Id = id,
            Title = book.Title,
            Author = author,
            Publisher = publisher,
            Isbn = book.Isbn,
            Edition = book.Edition,
            Price = book.Price,
            PublishDate = book.PublishDate
        };
    }

    public static BookSummaryDto ToBookSummaryDto(this Book book) {
        return new BookSummaryDto(
            book.Id,
            book.Title,
            book.Author.Name,
            book.Publisher.Name,
            book.Isbn,
            book.Edition,
            book.Price,
            book.PublishDate
        );
    }

    public static BookDetailsDto ToBookDetailsDto(this Book book) {
        return new BookDetailsDto(
            book.Id,
            book.Title,
            book.Author.Id,
            book.Publisher.Id,
            book.Isbn,
            book.Edition,
            book.Price,
            book.PublishDate
        );
    }
}