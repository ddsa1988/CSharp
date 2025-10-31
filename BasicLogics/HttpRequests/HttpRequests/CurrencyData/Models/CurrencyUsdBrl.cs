using System.Text.Json.Serialization;

namespace HttpRequests.CurrencyData.Models;

public class CurrencyUsdBrl {
    private const string CurrencyCode = "USDBRL";

    [JsonPropertyName($"{CurrencyCode}")] public required CurrencyInfo CurrencyInfo { get; init; }
}