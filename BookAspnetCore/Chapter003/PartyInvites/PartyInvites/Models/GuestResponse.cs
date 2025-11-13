namespace PartyInvites.Models;

public record GuestResponse(string? Name, string? Email, string? Phone, bool? WillAttend);