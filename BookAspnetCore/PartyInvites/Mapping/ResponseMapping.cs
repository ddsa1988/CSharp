using System.Text.Json;
using PartyInvites.Models;

namespace PartyInvites.Mapping;

public static class ResponseMapping {
    public static string ToJson(this Response response) {
        return JsonSerializer.Serialize(response);
    }

    public static Response? ToModel(this string json) {
        return JsonSerializer.Deserialize<Response>(json);
    }
}