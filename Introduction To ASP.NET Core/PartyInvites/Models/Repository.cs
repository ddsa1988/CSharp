namespace PartyInvites.Models;

public static class Repository {
    public static List<GuestResponse> Responses { get; private set; } = new List<GuestResponse>();

    public static void AddResponse(GuestResponse response) {
        Responses.Add(response);
    }
}