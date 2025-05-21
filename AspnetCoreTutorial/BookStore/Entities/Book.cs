using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Book {
    public int Id { get; init; }
    [StringLength(30)] public required string Title { get; init; }
    public required Author Author { get; init; }
    public required Publisher Publisher { get; init; }
    [StringLength(20)] public required string Isbn { get; init; }
    public required int Edition { get; init; }
    public required float Price { get; init; }
    public required DateOnly PublishDate { get; init; }
}