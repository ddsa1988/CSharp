namespace Chapter004.Delegates;

public static class Example002 {
    public static void Run() {
        // Plug-in Methods with Delegates

        {
            int[] numbers = [1, 2, 3];
            Transform(numbers, Square);
            Print(numbers);
        }

        {
            int[] numbers = [1, 2, 3];
            Transform(numbers, Cube);
            Print(numbers);
        }
    }

    private static void Print<T>(T[] arr) {
        Console.WriteLine(string.Join(", ", arr));
    }

    private static void Transform(int[]? values, Transformer t) {
        if (values == null || values.Length == 0) return;

        int length = values.Length;

        for (int i = 0; i < length; i++) {
            values[i] = t(values[i]);
        }
    }

    private delegate int Transformer(int x);

    private static int Square(int x) => x * x;

    private static int Cube(int x) => x * x * x;
}