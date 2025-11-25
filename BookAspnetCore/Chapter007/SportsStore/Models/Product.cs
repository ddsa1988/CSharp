using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models;

public class Product {
    public long? ProductId { get; init; }
    [MaxLength(30)] public string Name { get; init; } = string.Empty;
    [MaxLength(50)] public string Description { get; init; } = string.Empty;
    [Column(TypeName = "decimal(8,2)")] public decimal Price { get; init; }
    [MaxLength(30)] public string Category { get; init; } = string.Empty;
}