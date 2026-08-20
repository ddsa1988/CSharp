namespace UsingMethods.Examples;

internal static class OptionalParameters {
    internal static void Run() {
        EnterLogData("Error message");
        EnterLogData("Error message", "CFO");
    }

    private static void EnterLogData(string message, string owner = "Programmer") {
        Console.WriteLine("Error: " + message);
        Console.WriteLine("Owner of Error: " + owner);
        Console.WriteLine();
    }
}