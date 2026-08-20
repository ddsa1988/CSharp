namespace UsingMethods.Examples;

internal static class RefParameterModifier {
    internal static void Run() {
        int x = 10;
        int y = 20;

        Console.WriteLine($"Before: {x}, {y}");
        SwapNumbers(ref x, ref y);
        Console.WriteLine($"After: {x}, {y}");
    }

    private static void SwapNumbers(ref int a, ref int b) {
        (a, b) = (b, a);
    }
}