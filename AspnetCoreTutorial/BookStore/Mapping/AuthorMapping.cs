using BookStore.Dto.Author;
using BookStore.Entities;

namespace BookStore.Mapping;

public static class AuthorMapping {
    public static Author ToEntity(this CreateAuthorDto author) {
        return new Author() {
            Name = author.Name
        };
    }

    public static Author ToEntity(this UpdateAuthorDto author, int id) {
        return new Author() {
            Id = id,
            Name = author.Name
        };
    }

    public static AuthorDto ToDto(this Author author) {
        return new AuthorDto(author.Id, author.Name);
    }
}