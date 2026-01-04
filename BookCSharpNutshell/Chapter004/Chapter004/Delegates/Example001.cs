namespace Chapter004.Delegates;

public static class Example001 {
    /*
     * A delegate is a type that represents references to methods with a particular parameter list and return type.
     * When you instantiate a delegate, you can associate the delegate instance with any method that has a compatible
     * signature and return type. You can invoke (or call) the method through the delegate instance.
     */

    public static void Run() {
        const int x = 10;
        const int y = 20;

        Transformer transformer = Sum;
        Console.WriteLine(transformer.Invoke(x, y));
        Console.WriteLine(transformer(x, y));

        transformer = Sub;
        Console.WriteLine(transformer.Invoke(x, y));
        Console.WriteLine(transformer(x, y));
    }

    private delegate int Transformer(int x, int y);

    private static int Sum(int x, int y) => x + y;
    private static int Sub(int x, int y) => x - y;
}