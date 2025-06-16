using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public record Response(
    [Required(ErrorMessage = "Please enter your name")]
    string? Name,
    [Required(ErrorMessage = "Please enter your email address")]
    string? Email,
    [Required(ErrorMessage = "Please enter your phone number")]
    string? Phone,
    [Required(ErrorMessage = "Please specify whether you'll attend")]
    bool? WillAttend) {
    public override int GetHashCode() {
        return (Name != null ? Name.GetHashCode() : 0);
    }

    public virtual bool Equals(Response? other) {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return Name != null && Name.Equals(other.Name, StringComparison.InvariantCultureIgnoreCase);
    }
}