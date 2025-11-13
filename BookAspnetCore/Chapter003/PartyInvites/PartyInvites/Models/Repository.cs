using System.Text.Json;

namespace PartyInvites.Models;

public static class Repository {
    private static readonly List<GuestResponse> Responses;

    static Repository() {
        Responses = [];
    }

    public static IEnumerable<GuestResponse> GuestResponses => Responses;

    public static void AddGuestResponse(GuestResponse response) {
        Responses.Add(response);
    }

    public static string ToJson(this IEnumerable<GuestResponse> guestResponses) {
        List<GuestResponse> responses = guestResponses.ToList();

        if (responses.Count == 0) return string.Empty;

        string json = JsonSerializer.Serialize(responses, JsonWriteOptions);

        return json;
    }

    public static IEnumerable<GuestResponse> ToGuestResponsesRepository(this string json) {
        List<GuestResponse>? responses = null;

        try {
            responses = JsonSerializer.Deserialize<List<GuestResponse>>(json);
        } catch (JsonException ex) {
            Console.WriteLine(ex.Message);
        } catch (NotSupportedException ex) {
            Console.WriteLine(ex.Message);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        return responses ?? Enumerable.Empty<GuestResponse>();
    }

    private static readonly JsonSerializerOptions JsonWriteOptions = new() {
        WriteIndented = true
    };
}