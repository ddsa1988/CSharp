using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;

public class Publisher {
    public int Id { get; set; }
    [StringLength(30)] public required string Name { get; set; }
}