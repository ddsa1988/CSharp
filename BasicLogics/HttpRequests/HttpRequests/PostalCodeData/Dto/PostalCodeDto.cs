using System.Text.Json.Serialization;

namespace HttpRequests.PostalCodeData.Dto;

public record PostalCodeDto(
    [property: JsonPropertyName("cep")] string Code,
    [property: JsonPropertyName("address_type")]
    string AddressType,
    [property: JsonPropertyName("address_name")]
    string AddressName,
    [property: JsonPropertyName("address")]
    string Address,
    [property: JsonPropertyName("state")] string State,
    [property: JsonPropertyName("district")]
    string District,
    [property: JsonPropertyName("lat")] string Latitude,
    [property: JsonPropertyName("lng")] string Longitude,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("city_ibge")]
    string CityIbge,
    [property: JsonPropertyName("ddd")] string DirectDistanceDialing
);