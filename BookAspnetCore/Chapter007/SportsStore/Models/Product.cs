using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models;

public class Product {
    public long? ProductId { get; init; }
    [MaxLength(30)] public required string Name { get; init; }
    [MaxLength(50)] public required string Description { get; init; }
    [Column(TypeName = "decimal(8,2)")] public decimal Price { get; init; }
    [MaxLength(30)] public required string Category { get; init; }
}