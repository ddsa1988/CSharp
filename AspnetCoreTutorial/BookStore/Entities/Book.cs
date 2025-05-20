using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Book {
    public int Id { get; set; }
    [StringLength(30)] public required string Title { get; set; }
    [StringLength(30)] public required string Author { get; set; }
    [StringLength(30)] public required string Publisher { get; set; }
    [StringLength(20)] public required string Isbn { get; set; }
    public int Edition { get; set; }
    public float Price { get; set; }
    public DateOnly PublishDate;
}