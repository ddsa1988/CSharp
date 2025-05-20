using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Author {
    public int Id { get; set; }
    [StringLength(30)] public required string Name { get; set; }
}