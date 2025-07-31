using System.Text.Json;
using PartyInvites.Models;

namespace PartyInvites.Mapping;

public static class Mapping {
    public static string GuestResponseToJson(this GuestResponse guestResponse) {
        return JsonSerializer.Serialize(guestResponse);
    }

    public static GuestResponse? GuestResponseFromJson(this string json) {
        return JsonSerializer.Deserialize<GuestResponse>(json);
    }
}