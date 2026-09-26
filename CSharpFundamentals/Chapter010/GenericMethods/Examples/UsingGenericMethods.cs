namespace GenericMethods.Examples;

internal static class UsingGenericMethods {
    public static void Run() {
        int x = 10;
        int y = 20;

        Console.WriteLine($"Before swap: {x}, {y}");

        Swap<int>(ref x, ref y);

        Console.WriteLine($"After swap: {x}, {y}");
    }

    private static void Swap<T>(ref T a, ref T b) {
        Console.WriteLine("You sent the " + nameof(Swap) + "() method a " + typeof(T) + " .");
        (a, b) = (b, a);
    }
}