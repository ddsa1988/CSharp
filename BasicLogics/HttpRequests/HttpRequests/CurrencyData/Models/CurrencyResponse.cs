using System.Text.Json;
using System.Text.Json.Serialization;

namespace HttpRequests.CurrencyData.Models;

public class CurrencyResponse {
    [JsonExtensionData] public Dictionary<string, JsonElement>? CurrencyInfo { get; init; }
}