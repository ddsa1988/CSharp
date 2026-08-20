namespace UsingMethods.Examples;

internal static class ParamsParameterModifier {
    public static void Run() {
        int[] numbers = [1, 2, 3, 4, 5];

        Console.WriteLine("Average of data is: " + CalculateAverage(10, 20, 30) + "\n");
        Console.WriteLine("Average of data is: " + CalculateAverage(numbers) + "\n");
        Console.WriteLine("Average of data is: " + CalculateAverage() + "\n");
    }

    private static int CalculateAverage(params int[] values) {
        int sum = 0;

        Console.WriteLine($"You sent me {values.Length} ints.");

        if (values.Length == 0) return sum;

        foreach (int value in values) {
            sum += value;
        }

        return sum / values.Length;
    }
}