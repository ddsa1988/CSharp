namespace BasicDataTypes.Examples;

internal class DataTypeFunctionality {
    internal static void Run() {
        Console.WriteLine("=> Data type functionality:\n");

        Console.WriteLine($"Min of integers: {int.MinValue}");
        Console.WriteLine($"Max of integers: {int.MaxValue}");

        Console.WriteLine($"Min of doubles: {double.MinValue}");
        Console.WriteLine($"Max of doubles: {double.MaxValue}");

        Console.WriteLine($"Double epsilon: {double.Epsilon}");

        Console.WriteLine($"Double negative infinity: {double.NegativeInfinity}");
        Console.WriteLine($"Double positive infinity: {double.PositiveInfinity}");
    }
}