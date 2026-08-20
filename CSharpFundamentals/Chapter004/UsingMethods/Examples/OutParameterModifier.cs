namespace UsingMethods.Examples;

internal static class OutParameterModifier {
    internal static void Run() {
        const int x = 100;
        const int y = 200;

        int ans1 = 0;

        Console.WriteLine(ans1);

        Add(100, 200, out ans1);
        Add(100, 200, out int ans2);

        Console.WriteLine(ans1);
        Console.WriteLine(ans2);

        Console.WriteLine();

        FillTheseValues(out int i, out string str, out bool b);

        Console.Write($"{i}, {str}, {b}");
        Console.WriteLine("\n");

        FillTheseValues(out _, out string s, out _); // Discard as placeholder

        Console.WriteLine(s);
    }

    private static void Add(int x, int y, out int result) {
        result = x + y;
    }

    private static void FillTheseValues(out int a, out string b, out bool c) {
        a = 9;
        b = "Enjoy your string";
        c = true;
    }
}