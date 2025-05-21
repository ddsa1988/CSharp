using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Book {
    public int Id { get; init; }
    [StringLength(30)] public required string Title { get; init; }
    [StringLength(20)] public required string Isbn { get; init; }
    public required int AuthorId { get; init; }
    public Author? Author { get; init; }
    public required int PublisherId { get; init; }
    public Publisher? Publisher { get; init; }
    public required int Edition { get; init; }
    public required float Price { get; init; }
    public required DateOnly PublishDate { get; init; }
}