using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Models;

public class Product {
    public long? ProductId { get; init; }
    [StringLength(40)] public required string Name { get; init; }

    [StringLength(100)] public required string Description { get; init; }
    [Column(TypeName = "decimal(8,2)")] public required decimal Price { get; init; }
    [StringLength(30)] public required string Category { get; init; }
}