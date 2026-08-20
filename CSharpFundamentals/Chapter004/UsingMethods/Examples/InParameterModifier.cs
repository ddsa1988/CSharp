namespace UsingMethods.Examples;

internal static class InParameterModifier {
    internal static void Run() {
        const int x = 10;
        const int y = 20;

        Console.WriteLine(Add(x, y));
    }

    private static int Add(in int x, in int y) {
        int result = x + y;

        // Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
        // x = 1000;
        // y = 2000;

        return result;
    }
}