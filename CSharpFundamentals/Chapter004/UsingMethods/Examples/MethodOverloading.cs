namespace UsingMethods.Examples;

internal static class MethodOverloading {
    internal static void Run() {
        Console.WriteLine(Add(10, 20));
        Console.WriteLine(Add(50.75f, 10.1f));
    }

    private static int Add(int x, int y) => x + y;
    private static float Add(float x, float y) => x + y;
}