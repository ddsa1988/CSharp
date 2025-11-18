namespace LanguageFeatures.Models;

public static class MyAsyncMethods {
    public static async Task<long> GetPageLength(string url) {
        var client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(30);
        HttpResponseMessage? response = null;

        try {
            response = await client.GetAsync(url);
        } catch (HttpRequestException ex) {
            Console.WriteLine(ex.Message);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        if (response == null) {
            return 0;
        }

        if (response.IsSuccessStatusCode) return response.Content.Headers.ContentLength ?? 0;

        Console.WriteLine("Response status code: " + response.StatusCode);
        return 0;
    }

    public static async Task<IEnumerable<long>> GetPageLengths(List<string> output, params string[] urls) {
        var results = new List<long>();

        foreach (string url in urls) {
            output.Add($"Started request for {url}");
            results.Add(await GetPageLength(url));
            output.Add($"Completed request for {url}");
        }

        return results;
    }
}