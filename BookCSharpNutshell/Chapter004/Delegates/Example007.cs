namespace Chapter004.Delegates;

public static class Example007 {
    public static void Run() {
        // The Func and Action Delegates

        // delegate TResult Func <out TResult> ();
        // delegate TResult Func <in T1, in T.., out TResult> (T arg1, T arg..);

        // delegate void Action ();
        // delegate void Action <in T1, in T..> (T arg1, T arg..);

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

    private static void Transform<T>(T[]? values, Func<T, T> t) {
        if (values == null || values.Length == 0) return;

        int length = values.Length;

        for (int i = 0; i < length; i++) {
            values[i] = t(values[i]);
        }
    }

    private static int Square(int x) => x * x;

    private static double Square(double x) => x * x;
}