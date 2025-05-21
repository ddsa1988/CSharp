using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Author {
    public int Id { get; init; }
    [StringLength(30)] public required string Name { get; init; }
}