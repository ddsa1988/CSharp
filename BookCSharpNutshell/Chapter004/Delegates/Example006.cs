namespace Chapter004.Delegates;

public static class Example006 {
    public static void Run() {
        // A delegate type can contain generic type parameters.

        {
            int[] numbers = [1, 2, 3];
            Transform(numbers, Square);
            Print(numbers);
        }

        {
            double[] numbers = [1.5, 2.1, 3.6];
            Transform(numbers, Square);
            Print(numbers);
        }
    }

    private static void Print<T>(T[] arr) {
        Console.WriteLine(string.Join(", ", arr));
    }

    private static void Transform<T>(T[]? values, Transformer<T> t) {
        if (values == null || values.Length == 0) return;

        int length = values.Length;

        for (int i = 0; i < length; i++) {
            values[i] = t(values[i]);
        }
    }

    private delegate T Transformer<T>(T arg);

    private static int Square(int x) => x * x;

    private static double Square(double x) => x * x;
}