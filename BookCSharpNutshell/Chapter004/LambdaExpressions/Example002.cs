namespace Chapter004.LambdaExpressions;

public static class Example002 {
    public static void Run() {
        // A lambda expression can reference any variables that are accessible where the lambda expression is defined.
        // These are called outer variables, and can include local variables, parameters, and field.
        // Variables can also be captured by anonymous methods and local methods.
        // Captured variables are evaluated when the delegate, anonymous methods or local methods is invoked, not when the variable was captured.

        int factor = 2;

        Console.WriteLine("{0} = {1}", nameof(Multiplier), Multiplier(3));

        factor = 10;

        Console.WriteLine("{0} = {1}", nameof(Multiplier), Multiplier(3));

        return;

        int Multiplier(int n) => n * factor;
    }
}