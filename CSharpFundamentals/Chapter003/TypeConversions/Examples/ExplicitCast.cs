namespace TypeConversions.Examples;

internal static class ExplicitCast {
    internal static void Run() {
        short n1 = 9;
        short n2 = 10;

        short result = (short)Add(n1, n2);
        Console.WriteLine(result);

        n1 = 30000;
        n2 = 30000;

        result = (short)Add(n1, n2); // Overflow
        Console.WriteLine(result);
    }

    private static int Add(int x, int y) => x + y;
}