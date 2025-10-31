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
            _ => "EUR-BRL",
        };

        using var client = new HttpClient();

        string responseStr =
            await client.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL");

        Console.WriteLine(responseStr + Environment.NewLine);

        var currency =
            await client.GetFromJsonAsync<CurrencyResponse>(
                $"https://economia.awesomeapi.com.br/json/last/{currencyType}");

        if (currency?.CurrencyInfo == null) return;

        string currencyName = currency.CurrencyInfo.Keys.First();
        bool isDataValid = currency.CurrencyInfo.TryGetValue(currencyName, out JsonElement jsonCurrencyInfo);

        if (!isDataValid) return;

        var currencyInfo = JsonSerializer.Deserialize<CurrencyInfo>(jsonCurrencyInfo.ToString());
        Console.WriteLine(currencyInfo?.Name);
    }
}