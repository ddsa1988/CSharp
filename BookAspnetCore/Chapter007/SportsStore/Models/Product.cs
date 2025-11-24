using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models;

public class Product {
    public long? ProductId { get; set; }
    [MaxLength(30)] public string Name { get; set; } = string.Empty;
    [MaxLength(50)] public string Description { get; set; } = string.Empty;
    [Column(TypeName = "decimal(8,2)")] public decimal Price { get; set; }
    [MaxLength(30)] public string Category { get; set; } = string.Empty;
}