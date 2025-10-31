using System.Net.Http.Json;
using System.Text.Json;
using HttpRequests.CurrencyData.Models;

namespace HttpRequests.CurrencyData;

public static class Example {
    public static async Task Run() {
        // Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL

        const int selectCurrency = 3;

        string currencyType = selectCurrency switch {
            0 => "USD-BRL",
            1 => "EUR-BRL",
            2 => "BTC-BRL",
            _ => "USD-BRL,EUR-BRL,BTC-BRL"
        };

        using var client = new HttpClient();
        CurrencyResponse? content = null;
        HttpResponseMessage? response = null;

        try {
            response = await client.GetAsync($"https://economia.awesomeapi.com.br/json/last/{currencyType}");
        } catch (HttpRequestException e) {
            Console.WriteLine($"Http Request Exception: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"General Exception: {e.Message}");
        }

        if (response == null) return;

        if (!response.IsSuccessStatusCode) {
            Console.WriteLine("Error code: {0}", response.StatusCode);
            return;
        }

        try {
            content = await response.Content.ReadFromJsonAsync<CurrencyResponse>();
        } catch (OperationCanceledException e) {
            Console.WriteLine($"Operation Canceled Exception: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"General Exception: {e.Message}");
        }

        if (content?.CurrencyInfo == null) return;

        foreach ((string key, JsonElement value) in content.CurrencyInfo) {
            if (!content.CurrencyInfo.TryGetValue(key, out JsonElement jsonCurrencyInfo)) continue;

            var currencyInfo = JsonSerializer.Deserialize<CurrencyInfo>(jsonCurrencyInfo.ToString());

            if (currencyInfo == null) continue;

            Console.WriteLine(currencyInfo.Name);
        }
    }
}