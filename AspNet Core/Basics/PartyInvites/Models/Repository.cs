namespace PartyInvites.Models;

public static class Repository {
    public static List<GuestResponse> Responses { get; } = [];

    public static void AddResponse(GuestResponse response) {
        if (Responses.Contains(response)) return;

        Responses.Add(response);
    }
}