namespace PartyInvites.Models;

public class GuestResponse {
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PhoneNumber { get; init; }
    public required bool WillAttend { get; init; }
}