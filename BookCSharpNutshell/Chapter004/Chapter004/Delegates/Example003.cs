namespace Chapter004.Delegates;

public static class Example003 {
    public static void Run() {
        int[] values = [1, 2, 3];
        Transform(values, Square);
        Console.WriteLine($"Square: [{string.Join(", ", values)}]");

        values = [1, 2, 3];
        Transform(values, Cube);
        Console.WriteLine($"Cube: [{string.Join(", ", values)}]");
    }

    private delegate int Transformer(int x);

    private static void Transform(int[] values, Transformer transformer) {
        for (int i = 0; i < values.Length; i++) {
            values[i] = transformer(values[i]);
        }
    }

    private static int Square(int x) => x * x;
    private static int Cube(int x) => x * x * x;
}