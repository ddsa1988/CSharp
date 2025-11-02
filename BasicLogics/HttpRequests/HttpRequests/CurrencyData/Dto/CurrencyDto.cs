using System.Text.Json.Serialization;

namespace HttpRequests.CurrencyData.Dto;

public record CurrencyDto(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("codein")] string CodeIn,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("high")] string High,
    [property: JsonPropertyName("low")] string Low,
    [property: JsonPropertyName("varBid")] string VarBid,
    [property: JsonPropertyName("pctChange")]
    string PctChange,
    [property: JsonPropertyName("bid")] string Bid,
    [property: JsonPropertyName("ask")] string Ask,
    [property: JsonPropertyName("timestamp")]
    string Timestamp,
    [property: JsonPropertyName("create_date")]
    string CreateDateString
);