using System.Net.Http.Json;
using HttpRequests.PostalCodeData.Dto;

namespace HttpRequests.PostalCodeData;

public static class Example001 {
    public static async Task Run() {
        //Ex.: https://cep.awesomeapi.com.br/json/01001000

        const string apiEndpoint = "https://cep.awesomeapi.com.br/json/";
        const string postalCode = "82650480";

        var client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(30);

        HttpResponseMessage? response = null;
        PostalCodeDto? postalCodeDto = null;

        try {
            response = await client.GetAsync(apiEndpoint + postalCode);
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
            postalCodeDto = await response.Content.ReadFromJsonAsync<PostalCodeDto>();
        } catch (OperationCanceledException ex) {
            Console.WriteLine("Operation cancelled exception: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("General exception: " + ex.Message);
        }

        if (postalCodeDto == null) return;

        Console.WriteLine(postalCodeDto);
    }
}