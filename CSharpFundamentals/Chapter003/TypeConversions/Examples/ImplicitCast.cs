namespace TypeConversions.Examples;

internal static class ImplicitCast {
    internal static void Run() {
        const short n1 = 9;
        const short n2 = 10;

        int result = Add(n1, n2);
        Console.WriteLine(result);
    }

    private static int Add(int x, int y) => x + y;
}