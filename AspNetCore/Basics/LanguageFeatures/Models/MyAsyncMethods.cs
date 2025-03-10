namespace LanguageFeatures.Models;

public static class MyAsyncMethods {
    public static Task<long?> GetPageLength() {
        var client = new HttpClient();
        Task<HttpResponseMessage> httpTask = client.GetAsync("https://apress.com");
        
        return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => antecedent.Result.Content.Headers.ContentLength);
    }
}

