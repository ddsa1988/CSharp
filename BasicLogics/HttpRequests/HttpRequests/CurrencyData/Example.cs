using System.Net.Http.Json;
using HttpRequests.CurrencyData.Models;

namespace HttpRequests.CurrencyData;

public static class Example {
    public static async Task Run() {
        // Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL
        const string currencyType = "EUR-BRL";

        using var client = new HttpClient();

        string responseStr =
            await client.GetStringAsync($"https://economia.awesomeapi.com.br/json/last/{currencyType}");
        Console.WriteLine(responseStr + Environment.NewLine);

        var currencyResponse =
            await client.GetFromJsonAsync<CurrencyResponse>(
                $"https://economia.awesomeapi.com.br/json/last/{currencyType}");

        if (currencyResponse == null) {
            Console.WriteLine("CurrencyResponse is null");
            return;
        }

        Console.WriteLine($"Currency name: {currencyResponse.CurrencyInfo.Name}");
    }
}