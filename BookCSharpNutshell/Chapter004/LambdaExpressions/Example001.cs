namespace Chapter004.LambdaExpressions;

public static class Example001 {
    public static void Run() {
        // A lambda expression is an unnamed method written in place of a delegate instance.

        Console.WriteLine("{0} = {1}", nameof(Square), Square(3));
    }

    private static readonly Func<int, int> Square = x => x * x; // 'x' is a lambda expression
}