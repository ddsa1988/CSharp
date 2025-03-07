using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public class GuestResponse {
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Please enter your email address")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Please specify whether you'll attend")]
    public bool? WillAttend { get; set; }

    public override int GetHashCode() {
        return Name == null ? 0 : Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;

        if (ReferenceEquals(this, obj)) return true;

        var other = obj as GuestResponse;

        return other != null && Equals(other.Name, Name);
    }
}