using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Models;

public class Product {
    public long? ProductId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    [Column(TypeName = "decimal(8,2)")] public required decimal Price { get; set; }
    public required string Category { get; set; }
}