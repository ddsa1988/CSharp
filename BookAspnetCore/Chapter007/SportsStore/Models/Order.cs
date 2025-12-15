using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models;

public class Order {
    [BindNever] public int OrderId { get; set; }
    [BindNever] public ICollection<CartLine> CartLines { get; set; } = new List<CartLine>();

    [Required(ErrorMessage = "Please enter a name")]
    [MaxLength(30)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter the first address line")]
    [MaxLength(20)]
    public string? AddressLine1 { get; set; }

    [MaxLength(20)] public string? AddressLine2 { get; set; }
    [MaxLength(20)] public string? AddressLine3 { get; set; }

    [Required(ErrorMessage = "Please enter a city name")]
    [MaxLength(20)]
    public string? City { get; set; }

    [Required(ErrorMessage = "Please enter a state name")]
    [MaxLength(20)]
    public string? State { get; set; }

    [Required(ErrorMessage = "Please enter a country name")]
    [MaxLength(20)]
    public string? Country { get; set; }

    [MaxLength(10)] public string? ZipCode { get; set; }

    public bool GiftWrap { get; set; }

    [BindNever] public bool Shipped { get; set; }
}