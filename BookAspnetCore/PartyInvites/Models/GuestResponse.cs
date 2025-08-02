using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public class GuestResponse {
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; init; }

    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    public string? Email { get; init; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone { get; init; }

    [Required(ErrorMessage = "Please specify whether you'll attend")]
    public bool? WillAttend { get; init; }
}