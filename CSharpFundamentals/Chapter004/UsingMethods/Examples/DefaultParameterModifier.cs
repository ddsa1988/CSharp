namespace UsingMethods.Examples;

internal static class DefaultParameterModifier {
    internal static void Run() {
        // Pass parameter by value => copy of the original data

        const int x = 10;
        const int y = 20;
        int[] myNumbers = [10, 20, 30];

        Console.WriteLine($"Before call: {nameof(x)}: {x}, {nameof(y)}: {y}");
        Add(x, y);
        Console.WriteLine($"After call: {nameof(x)}: {x}, {nameof(y)}: {y}");

        Console.WriteLine();

        Console.WriteLine($"Before call: {nameof(myNumbers)}: {string.Join(" ", myNumbers)}");
        ChangeArray(myNumbers);
        Console.WriteLine($"After call: {nameof(myNumbers)}: {string.Join(" ", myNumbers)}");
    }

    private static int Add(int x, int y) {
        int result = x + y;

        x = 1000;
        y = 2000;

        return result;
    }

    private static void ChangeArray(int[] numbers) {
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] *= 2;
        }
    }
}