namespace UsingMethods.Examples;

internal static class ParamsParameterModifier {
    public static void Run() {
        int[] numbers = [1, 2, 3, 4, 5];

        Console.WriteLine(CalculateAverage(10, 20, 30));
        Console.WriteLine(CalculateAverage(numbers));
        Console.WriteLine(CalculateAverage());
    }

    private static int CalculateAverage(params int[] values) {
        int sum = 0;

        if (values.Length == 0) return sum;

        foreach (int value in values) {
            sum += value;
        }

        return sum / values.Length;
    }
}