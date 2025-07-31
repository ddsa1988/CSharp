namespace PartyInvites.Models;

public class GuestResponse {
    public string? Name { get; init; }
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public bool? WillAttend { get; init; }
}