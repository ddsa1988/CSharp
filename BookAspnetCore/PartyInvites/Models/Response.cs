namespace PartyInvites.Models;

public record Response(string? Name, string? Email, string? Phone, bool? WillAttend) {
    public override int GetHashCode() {
        return (Name != null ? Name.GetHashCode() : 0);
    }

    public virtual bool Equals(Response? other) {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return Name != null && Name.Equals(other.Name, StringComparison.InvariantCultureIgnoreCase);
    }
}