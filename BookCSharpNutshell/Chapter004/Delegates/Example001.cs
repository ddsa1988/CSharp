namespace Chapter004.Delegates;

public static class Example001 {
    public static void Run() {
        // A delegate type defines the kind of method that delegate instances can call.
        // Specifically, it defines the method’s return type and its parameter types.

        {
            var t = new Transformer(Square);
            Console.WriteLine("{0} = {1}", nameof(t), t.Invoke(3));
        }

        {
            Transformer t = Cube;
            Console.WriteLine("{0} = {1}", nameof(t), t(3));
        }
    }

    private delegate int Transformer(int x);

    private static int Square(int x) => x * x;

    private static int Cube(int x) => x * x * x;
}