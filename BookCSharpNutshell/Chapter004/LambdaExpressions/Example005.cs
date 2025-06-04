namespace Chapter004.LambdaExpressions;

public static class Example005 {
    public static void Run() {
        // Static lambdas

        /*
         int factor = 2;
         Func<int, int> multiplier = static n => n * factor; // Compile-time error
        */

        Func<int, int> multiplier = static n => n * 2;

        Console.WriteLine("{0} = {1}", nameof(multiplier), multiplier(3));
    }
}