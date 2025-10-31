using System.Net.Http.Json;
using System.Text.Json;
using HttpRequests.CurrencyData.Models;

namespace HttpRequests.CurrencyData;

public static class Example {
    public static async Task Run() {
        // Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL

        const int selectCurrency = 0;

        string currencyType = selectCurrency switch {
            0 => "USD-BRL",
            1 => "EUR-BRL",
            2 => "BTC-BRL",
            _ => "USD-BRL,EUR-BRL,BTC-BRL"
        };

        using var client = new HttpClient();
        CurrencyResponse? currency = null;

        try {
            currency =
                await client.GetFromJsonAsync<CurrencyResponse>(
                    $"https://economia.awesomeapi.com.br/json/last/{currencyType}");
        } catch (HttpRequestException e) {
            Console.WriteLine($"HttpRequestException: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"GeneralException: {e.Message}");
        }

        if (currency?.CurrencyInfo == null) return;

        foreach ((string key, JsonElement value) in currency.CurrencyInfo) {
            if (!currency.CurrencyInfo.TryGetValue(key, out JsonElement jsonCurrencyInfo)) continue;

            var currencyInfo = JsonSerializer.Deserialize<CurrencyInfo>(jsonCurrencyInfo.ToString());

            if (currencyInfo == null) continue;

            Console.WriteLine(currencyInfo.Name);
        }
    }
}