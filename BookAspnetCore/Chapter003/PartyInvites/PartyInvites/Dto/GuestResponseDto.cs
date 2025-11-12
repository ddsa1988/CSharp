namespace PartyInvites.Dto;

public record GuestResponseDto(string? Name, string? Email, string? PhoneNumber, bool? WillAttend);