namespace HttpRequests;

public static class Program {
    public static async Task Main(string[] args) {
        await CurrencyData.Example.Run();
    }
}