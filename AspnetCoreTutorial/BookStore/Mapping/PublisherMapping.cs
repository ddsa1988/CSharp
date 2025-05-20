using BookStore.Dto.Publisher;
using BookStore.Entities;

namespace BookStore.Mapping;

public static class PublisherMapping {
    public static Publisher ToEntity(this CreatePublisherDto publisher) {
        return new Publisher() {
            Name = publisher.Name
        };
    }

    public static Publisher ToEntity(this UpdatePublisherDto publisher, int id) {
        return new Publisher() {
            Id = id,
            Name = publisher.Name
        };
    }

    public static PublisherDto ToDto(this Publisher publisher) {
        return new PublisherDto(publisher.Id, publisher.Name);
    }
}