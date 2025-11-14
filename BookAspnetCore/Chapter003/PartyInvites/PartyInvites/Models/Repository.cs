using System.Text.Json;
using PartyInvites.Utilities;

namespace PartyInvites.Models;

public static class Repository {
    private static readonly List<GuestResponse> Responses;

    private static readonly JsonSerializerOptions JsonWriteOptions = new() {
        WriteIndented = true
    };

    static Repository() {
        Responses = InitializeRepository();
    }

    private static List<GuestResponse> InitializeRepository() {
        List<GuestResponse>? responses = null;
        string json = RepositoryFile.Read();

        if (string.IsNullOrEmpty(json.Trim())) return [];

        try {
            responses = JsonSerializer.Deserialize<List<GuestResponse>>(json);
        } catch (JsonException ex) {
            Console.WriteLine(ex.Message);
        } catch (NotSupportedException ex) {
            Console.WriteLine(ex.Message);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        return responses ?? [];
    }

    public static IEnumerable<GuestResponse> GuestResponses => Responses;

    public static void AddGuestResponse(GuestResponse response) {
        Responses.Add(response);
    }

    // Extension methods
    public static string ToJson(this IEnumerable<GuestResponse> guestResponses) {
        List<GuestResponse> responses = guestResponses.ToList();

        if (responses.Count == 0) return string.Empty;

        string json = JsonSerializer.Serialize(responses, JsonWriteOptions);

        return json;
    }
}