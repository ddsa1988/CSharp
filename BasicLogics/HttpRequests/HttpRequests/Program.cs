namespace HttpRequests;

public static class Program {
    public static async Task Main(string[] args) {
        await PostalCodeData.Example001.Run();
    }
}