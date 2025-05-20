using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Book {
    public int Id { get; set; }
    [StringLength(30)] public required string Title { get; set; }
    [StringLength(20)] public required string Isbn { get; set; }
    public required int AuthorId { get; set; }
    public Author? Author { get; set; }
    public required int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public required int Edition { get; set; }
    public required float Price { get; set; }
    public required DateOnly PublishDate;
}