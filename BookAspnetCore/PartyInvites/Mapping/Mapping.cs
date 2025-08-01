using System.Text.Json;
using PartyInvites.Models;

namespace PartyInvites.Mapping;

public static class Mapping {
    public static string? GuestResponseToJson(this GuestResponse guestResponse) {
        string? json = null;

        try {
            json = JsonSerializer.Serialize(guestResponse);
        } catch (Exception e) {
            Console.WriteLine("General error: " + e.Message);
        }

        return json;
    }

    public static GuestResponse? GuestResponseFromJson(this string json) {
        GuestResponse? guestResponse = null;

        try {
            guestResponse = JsonSerializer.Deserialize<GuestResponse>(json);
        } catch (JsonException e) {
            Console.WriteLine("Invalid Json format: " + e.Message);
        } catch (Exception e) {
            Console.WriteLine("General error: " + e.Message);
        }

        return guestResponse;
    }
}