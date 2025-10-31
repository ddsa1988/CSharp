using System.Net.Http.Json;
using HttpRequests.CurrencyData.Models;

namespace HttpRequests.CurrencyData;

public static class Example001 {
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
        client.Timeout = TimeSpan.FromSeconds(30);

        HttpResponseMessage? response = null;
        Dictionary<string, CurrencyInfo>? currencies = null;

        try {
            response = await client.GetAsync($"https://economia.awesomeapi.com.br/json/last/{currencyType}");
        } catch (HttpRequestException e) {
            Console.WriteLine($"Http Request Exception: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"General Exception: {e.Message}");
        }

        if (response == null) return;

        if (!response.IsSuccessStatusCode) {
            Console.WriteLine($"Error code: {response.StatusCode}");
            return;
        }

        try {
            currencies = await response.Content.ReadFromJsonAsync<Dictionary<string, CurrencyInfo>>();
        } catch (OperationCanceledException e) {
            Console.WriteLine($"Operation Canceled Exception: {e.Message}");
        } catch (Exception e) {
            Console.WriteLine($"General Exception: {e.Message}");
        }

        if (currencies == null) return;

        foreach ((string key, CurrencyInfo currencyInfo) in currencies) {
            Console.WriteLine($"{key}: {currencyInfo}{Environment.NewLine}");
        }
    }
}