using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models;

public class Product {
    public long? ProductId { get; init; }

    [Required(ErrorMessage = "Please enter aproduct name")]
    [MaxLength(30)]
    public string Name { get; init; } = string.Empty;

    [Required(ErrorMessage = "Please enter a description")]
    [MaxLength(50)]
    public string Description { get; init; } = string.Empty;

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
    [Column(TypeName = "decimal(8,2)")]
    public decimal Price { get; init; }

    [Required(ErrorMessage = "Please specify a category")]
    [MaxLength(30)]
    public string Category { get; init; } = string.Empty;
}