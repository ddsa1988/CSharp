using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public record GuestResponse(
    [Required(ErrorMessage = "Please enter you name")]
    string? Name,
    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    string? Email,
    [Required(ErrorMessage = "Please enter your phone number")]
    string? Phone,
    [Required(ErrorMessage = "Please specify whether you'll attend")]
    bool? WillAttend);