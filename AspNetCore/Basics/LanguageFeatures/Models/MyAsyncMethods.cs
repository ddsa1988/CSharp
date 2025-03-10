namespace LanguageFeatures.Models;

public static class MyAsyncMethods {
    public static async Task<long?> GetPageLength() {
        var client = new HttpClient();
        HttpResponseMessage httpMessage = await client.GetAsync("https://apress.com");

        return httpMessage.Content.Headers.ContentLength;
    }

    public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output, params string[] urls) {
        var client = new HttpClient();

        foreach (string url in urls) {
            output.Add($"Started request for {url}");
            HttpResponseMessage httpMessage = await client.GetAsync($"https://{url}");
            output.Add($"Completed request for {url}");

            yield return httpMessage.Content.Headers.ContentLength;
        }
    }
}

