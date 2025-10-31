using System.Net.Http.Json;
using HttpRequests.CurrencyData.Models;

namespace HttpRequests.CurrencyData;

public static class Example {
    public static async Task Run() {
        // Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL
        const string eurBrl = "EUR-BRL";
        const string usdBrl = "USD-BRL";

        using var client = new HttpClient();

        string responseStr =
            await client.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL");

        Console.WriteLine(responseStr + Environment.NewLine);

        var currencyEurBrl =
            await client.GetFromJsonAsync<CurrencyEurBrl>($"https://economia.awesomeapi.com.br/json/last/{eurBrl}");

        var currencyUsdBrl =
            await client.GetFromJsonAsync<CurrencyUsdBrl>($"https://economia.awesomeapi.com.br/json/last/{usdBrl}");


        Console.WriteLine($"Currency name: {currencyEurBrl?.CurrencyInfo.Name}");
        Console.WriteLine($"Currency name: {currencyUsdBrl?.CurrencyInfo.Name}");
    }
}