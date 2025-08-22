namespace Examples.RoundingErrors;

public static class Example001 {
    public static void Run() {
        Console.WriteLine(0.1F + 0.2F == 0.3F); // Float
        Console.WriteLine(0.1 + 0.2 == 0.3); // Double
        Console.WriteLine(0.1M + 0.2M == 0.3M); // Decimal
    }
}