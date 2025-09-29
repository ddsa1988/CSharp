namespace Examples.LambdaExpressions;

public static class Example001 {
    private static readonly Random Random = new Random();

    public static void Run() {
        double value = GetRandomDouble(100);
        PrintValue(value);
    }

    private static double GetRandomDouble(int max) => max * Random.NextDouble();

    private static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
}