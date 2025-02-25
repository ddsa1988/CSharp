namespace PartyInvites.Models;

public static class Repository {
    private static List<GuestResponse> _responses = [];

    public static IEnumerable<GuestResponse> Responses => _responses;

    public static void AddResponse(GuestResponse response) {
        if (_responses.Contains(response)) return;

        _responses.Add(response);
    }
}