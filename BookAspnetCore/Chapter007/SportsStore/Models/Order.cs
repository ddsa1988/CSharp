using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models;

public class Order {
    [BindNever] public int OrderId { get; set; }
    [BindNever] public ICollection<CartLine> CartLines { get; set; } = new List<CartLine>();

    [Required(ErrorMessage = "Please enter a name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter the first address line")]
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }

    [Required(ErrorMessage = "Please enter a city name")]
    public string? City { get; set; }

    [Required(ErrorMessage = "Please enter a state name")]
    public string? State { get; set; }

    [Required(ErrorMessage = "Please enter a country name")]
    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public bool GiftWrap { get; set; }
}