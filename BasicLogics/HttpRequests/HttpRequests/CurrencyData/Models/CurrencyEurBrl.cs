using System.Text.Json.Serialization;

namespace HttpRequests.CurrencyData.Models;

public class CurrencyEurBrl {
    private const string CurrencyCode = "EURBRL";

    [JsonPropertyName($"{CurrencyCode}")] public required CurrencyInfo CurrencyInfo { get; init; }
}