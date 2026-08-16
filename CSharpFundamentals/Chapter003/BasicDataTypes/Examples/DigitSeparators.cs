namespace BasicDataTypes.Examples;

internal static class DigitSeparators {
    internal static void Run() {
        Console.WriteLine("=> Digit Separators:\n");

        Console.WriteLine("Integer: " + 123_456);
        Console.WriteLine("Long: " + 123_456_789L);
        Console.WriteLine("Float: " + 123_456.123F);
        Console.WriteLine("Double: " + 123_456.12);
        Console.WriteLine("Decimal: " + 123_456.12m);
        Console.WriteLine("Hexadecimal: " + 0x_00_00_FF);
    }
}