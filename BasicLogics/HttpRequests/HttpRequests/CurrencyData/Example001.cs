using System.Net.Http.Json;
using HttpRequests.CurrencyData.Dto;

namespace HttpRequests.CurrencyData;

public static class Example001 {
    public static async Task Run() {
        // Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL

        const string apiEndpoint = "https://economia.awesomeapi.com.br/last/";
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
        Dictionary<string, CurrencyDto>? currenciesDto = null;

        try {
            response = await client.GetAsync(apiEndpoint + currencyType);
        } catch (HttpRequestException ex) {
            Console.WriteLine("Http request exception: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("General exception: " + ex.Message);
        }

        if (response == null) return;

        if (!response.IsSuccessStatusCode) {
            Console.WriteLine("Response status code: " + response.StatusCode);
            return;
        }

        try {
            currenciesDto = await response.Content.ReadFromJsonAsync<Dictionary<string, CurrencyDto>>();
        } catch (OperationCanceledException ex) {
            Console.WriteLine("Operation canceled exception: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("General exception: " + ex.Message);
        }

        if (currenciesDto == null) return;

        foreach ((string key, CurrencyDto currencyInfo) in currenciesDto) {
            Console.WriteLine($"{key}: {currencyInfo}{Environment.NewLine}");
        }
    }
}